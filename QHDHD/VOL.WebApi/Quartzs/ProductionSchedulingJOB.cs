using Quartz;
using System.Data;
using System.Threading.Tasks;
using System;
using YourNamespace;
using VOL.Entity.DomainModels;
using VOL.System.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using Help;
using VOL.WebApi.Common;
using VOL.System.FMS;
using System.Linq;
using Castle.DynamicProxy;
using Dm;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;

namespace VOL.WebApi.Quartzs
{
    public class ProductionSchedulingJOB : IJob
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private static object lockObject = new object();

        public ProductionSchedulingJOB(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    lock (lockObject)
                    {
                        Pac_Routing_OpService pacRoutingOpService = scope.ServiceProvider.GetRequiredService<Pac_Routing_OpService>();
                        // 获取所有结果
                        List<Pac_Routing_Op> Pac_Routing_Ops = pacRoutingOpService.GetAllInfo();
                        View_MES_WorkpieceInfoService wpic = scope.ServiceProvider.GetRequiredService<View_MES_WorkpieceInfoService>();
                        MES_WorkpieceInfoDetailService wpicde = scope.ServiceProvider.GetRequiredService<MES_WorkpieceInfoDetailService>();
                        MES_ProductSchedulingService mps = scope.ServiceProvider.GetRequiredService<MES_ProductSchedulingService>();
                        string sql = string.Empty;
                        MES_ProductScheduling mpod = mps.getOrderByTime();
                        int proisnum = (mpod == null || mpod.SortNum == null) ? 0 : mpod.SortNum ?? 0;
                        string procd = string.Empty;
                        int prcnum = 1;
                        if (mpod != null && mpod.ProCode != null && mpod.ProCode.Substring(3, 8) == DateTime.Now.ToString("yyyyMMdd"))
                        {
                            // 如果最新编码的日期与当前日期一致，提取后四位编码并加 1
                            int sequence = int.Parse(mpod.ProCode.Substring(11));
                            prcnum = sequence + 1;
                            procd = mpod.ProCode.Substring(0, 11);
                        }
                        else
                        {
                            // 如果最新编码的日期与当前日期不一致，日期改为今天，编码从 0001 开始
                            procd = $"PCH{DateTime.Now.ToString("yyyyMMdd")}";
                            prcnum = 1;
                        }
                        // 处理结果
                        foreach (Pac_Routing_Op op in Pac_Routing_Ops)
                        {
                            // 根据订单中任务号（暂定）搜索工单 
                            View_MES_WorkpieceInfo vic = wpic.GetInfo(op.order_no);
                            if (vic != null)
                            {
                                //根据订单搜索明细
                                List<MES_WorkpieceInfoDetail> widte = wpicde.GetDeInfo(vic.WIID);
                                // 将逗号分隔的刀型编号字符串拆分为列表
                                string[] knifeList = widte.Select(x => x.ToolTypeNumber).ToArray();

                                if (knifeList.Any())
                                {
                                    // 检查刀具是否可用
                                    bool isok = CheckKnifeAvailability(knifeList);
                                    SaveModel saveModel = new SaveModel();
                                    op.IsProduct = isok ? "1" : "0";
                                    saveModel.MainData = ConvertToDictionary(op);
                                    pacRoutingOpService.Update(saveModel);
                                    //sql = @"INSERT INTO dbo.MES_ProductScheduling(OP_ID,Status,ProgramNum,SortNum,Enable,UpdateTime,CreateUser,CreateTime,ProCode,Adjustment,Remarks,ProductionSchedulingTime)
                                    //VALUES(@OP_ID,@Status,@ProgramNum,@SortNum,@Enable,@UpdateTime,@CreateUser,@CreateTime,@ProCode,@Adjustment,@Remarks,@ProductionSchedulingTime)";
                                    //DbHelp<MES_ProductScheduling>.ExecuteNonQueryWithObject(sql, new
                                    //{
                                    //    OP_ID = op.ID,
                                    //    Status = 0,
                                    //    ProgramNum = vic.MachiningProgram,
                                    //    SortNum = proisnum,
                                    //    Enable = 1,
                                    //    UpdateTime = DateTime.Now,
                                    //    CreateUser = "admin",
                                    //    CreateTime = DateTime.Now,
                                    //    ProCode = procd + prcnum.ToString("D4"),
                                    //    Adjustment = string.Empty,
                                    //    Remarks = string.Empty,
                                    //    ProductionSchedulingTime = DateTime.Now
                                    //});
                                    if (isok)
                                    {
                                        saveModel = new SaveModel();
                                        saveModel.MainData = new Dictionary<string, object>
                                                        {
                                                            {"OP_ID", op.ID },
                                                            {"Status", 0 },
                                                            {"ProgramNum", vic.MachiningProgram },
                                                            {"SortNum", proisnum },
                                                            {"Enable", 1 },
                                                            {"UpdateTime", DateTime.Now },
                                                            {"CreateUser", "admin" },
                                                            {"CreateTime", DateTime.Now },
                                                            {"ProCode", procd + prcnum.ToString("D4") },
                                                            {"Adjustment", string.Empty },
                                                            {"Remarks", string.Empty },
                                                            {"ProductionSchedulingTime", DateTime.Now }
                                                        };
                                        mps.Add(saveModel);
                                        proisnum++;
                                        prcnum++;
                                    }
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 检查刀具可用性的主方法
        /// </summary>
        /// <param name="knifeTypeNumbers">逗号分隔的刀型编号字符串</param>
        /// <returns>检查通过返回 true，不通过返回 false</returns>
        static bool CheckKnifeAvailability(string [] knifeList)
        {
            // 用于存储从 cnc1daoku 表中查询到的结果
            var cncResults = new List<VOL.System.FMS.Cnc1daoku>();

            // 第一步：在 cnc1daoku 中查询
            foreach (var item in knifeList.Select(knife => new { ToolTypeNumber = knife }))
            {
                // 构建查询 cnc1daoku 表的 SQL 语句，根据刀型编号查询
                string sql = "select * from Cnc1daoku where 刀型编号 = @Dxbh";
                // 调用 DbHelp 类的查询方法，传入 SQL 语句和查询参数
                var result = DbHelp<VOL.System.FMS.Cnc1daoku>.QuerySingleOrDefaultWithParams(sql, new { Dxbh = item.ToolTypeNumber });
                if (result != null)
                {
                    // 如果查询到结果，将其添加到 cncResults 列表中
                    cncResults.Add(result);
                }
            }

            // 从查询结果中提取出找到的刀型编号列表
            var foundKnifeNumbers = cncResults.Select(r => r.刀型编号).ToList();
            // 找出在 cnc1daoku 表中未找到的刀型编号列表
            var notFoundKnifeNumbers = knifeList.Except(foundKnifeNumbers).ToList();

            if (foundKnifeNumbers.Count == knifeList.Count())
            {
                // 所有刀型编号都在 cnc1daoku 中找到
                // 从查询结果中提取出不同的机器编号
                var machineCodes = cncResults.Select(r => r.机器编号).Distinct().ToList();
                if (machineCodes.Count == 1)
                {
                    // 机器编号一致
                    // 找出刀具状态不为“已装载”的刀型编号列表
                    var unloadedKnives = cncResults.Where(r => r.刀具状态 != "已装载").Select(r => r.刀型编号).ToList();
                    if (unloadedKnives.Count == 0)
                    {
                        // 所有刀具状态为已装载
                        return true;
                    }
                    else
                    {
                        // 有未装载的刀具，去 kuozhangdaoku 中查询
                        return CheckInKuoZhangDaoKu(unloadedKnives);
                    }
                }
                else
                {
                    // 机器编号不一致
                    // 找出刀位性质不为“临时刀位”的记录
                    var fixedKnives = cncResults.Where(r => r.刀位性质 != "临时刀位").ToList();
                    // 从固定刀位记录中提取出不同的机器编号
                    var fixedMachineCodes = fixedKnives.Select(r => r.机器编号).Distinct().ToList();
                    if (fixedMachineCodes.Count == 1)
                    {
                        // 固定刀位在同一机器编码
                        // 找出固定刀位中刀具状态不为“已装载”的刀型编号列表
                        var unloadedFixedKnives = fixedKnives.Where(r => r.刀具状态 != "已装载").Select(r => r.刀型编号).ToList();
                        if (unloadedFixedKnives.Count > 0)
                        {
                            // 有未装载的固定刀位刀具，去 kuozhangdaoku 中查询
                            return CheckInKuoZhangDaoKu(unloadedFixedKnives);
                        }
                        return false;
                    }
                    else
                    {
                        // 固定刀位不在同一机器编码，去 kuozhangdaoku 中查询
                        // 找出所有刀具状态不为“已装载”的刀型编号列表
                        var allUnloadedKnives = cncResults.Where(r => r.刀具状态 != "已装载").Select(r => r.刀型编号).ToList();
                        return CheckInKuoZhangDaoKu(allUnloadedKnives);
                    }
                }
            }
            else
            {
                // 有刀型编号在 cnc1daoku 中未找到，去 kuozhangdaoku 中查询
                if (!CheckInKuoZhangDaoKu(notFoundKnifeNumbers))
                {
                    return false;
                }

                // 同时检查 cnc1daoku 中查到的数据是否符合条件 2 或 3
                if (cncResults.Count > 0)
                {
                    // 从查询结果中提取出不同的机器编号
                    var machineCodes = cncResults.Select(r => r.机器编号).Distinct().ToList();
                    if (machineCodes.Count == 1)
                    {
                        // 机器编号一致
                        // 找出刀具状态不为“已装载”的刀型编号列表
                        var unloadedKnives = cncResults.Where(r => r.刀具状态 != "已装载").Select(r => r.刀型编号).ToList();
                        if (unloadedKnives.Count > 0)
                        {
                            // 有未装载的刀具，去 kuozhangdaoku 中查询
                            return CheckInKuoZhangDaoKu(unloadedKnives);
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        // 机器编号不一致
                        // 找出刀位性质不为“临时刀位”的记录
                        var fixedKnives = cncResults.Where(r => r.刀位性质 != "临时刀位").ToList();
                        // 从固定刀位记录中提取出不同的机器编号
                        var fixedMachineCodes = fixedKnives.Select(r => r.机器编号).Distinct().ToList();
                        if (fixedMachineCodes.Count == 1)
                        {
                            // 固定刀位在同一机器编码
                            // 找出固定刀位中刀具状态不为“已装载”的刀型编号列表
                            var unloadedFixedKnives = fixedKnives.Where(r => r.刀具状态 != "已装载").Select(r => r.刀型编号).ToList();
                            if (unloadedFixedKnives.Count > 0)
                            {
                                // 有未装载的固定刀位刀具，去 kuozhangdaoku 中查询
                                return CheckInKuoZhangDaoKu(unloadedFixedKnives);
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            // 固定刀位不在同一机器编码，去 kuozhangdaoku 中查询
                            // 找出所有刀具状态不为“已装载”的刀型编号列表
                            var allUnloadedKnives = cncResults.Where(r => r.刀具状态 != "已装载").Select(r => r.刀型编号).ToList();
                            return CheckInKuoZhangDaoKu(allUnloadedKnives);
                        }
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// 在 kuozhangdaoku 表中查询指定刀型编号的刀具，要求仓位状态为“已装载”
        /// </summary>
        /// <param name="knifeNumbers">刀型编号列表</param>
        /// <returns>查询通过返回 true，不通过返回 false</returns>
        static bool CheckInKuoZhangDaoKu(List<string?> knifeNumbers)
        {
            // 用于存储从 kuozhangdaoku 表中查询到的结果
            var kuoZhangResults = new List<VOL.System.FMS.Kuozhangdaoku>();
            foreach (var item in knifeNumbers.Select(knife => new { ToolTypeNumber = knife }))
            {
                // 构建查询 kuozhangdaoku 表的 SQL 语句，根据刀型编号和仓位状态查询
                string sql = "select * from Kuozhangdaoku where 刀型编号 = @Dxbh and 刀具状态 = '已装载'";
                // 调用 DbHelp 类的查询方法，传入 SQL 语句和查询参数
                var result = DbHelp<VOL.System.FMS.Kuozhangdaoku>.QuerySingleOrDefaultWithParams(sql, new { Dxbh = item.ToolTypeNumber });
                if (result != null)
                {
                    // 如果查询到结果，将其添加到 kuoZhangResults 列表中
                    kuoZhangResults.Add(result);
                }
            }

            // 从查询结果中提取出找到的刀型编号列表
            var foundInKuoZhang = kuoZhangResults.Select(r => r.刀型编号).ToList();
            return foundInKuoZhang.Count == knifeNumbers.Count;
        }

        /// <summary>
        /// 实体转为字典
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Dictionary<string, object> ConvertToDictionary(object obj)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            if (obj == null)
            {
                return dictionary;
            }
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.CanRead)
                {
                    object value = property.GetValue(obj);
                    dictionary.Add(property.Name, value);
                }
            }
            return dictionary;
        }
    }
}
