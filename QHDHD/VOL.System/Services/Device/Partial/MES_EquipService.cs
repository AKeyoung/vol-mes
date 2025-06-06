/*
 *所有关于MES_Equip类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*MES_EquipService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
*/
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using System.Linq;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using VOL.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using VOL.System.IRepositories;
using System.Collections.Generic;
using System.Net;
using System;

namespace VOL.System.Services
{
    public partial class MES_EquipService
    {
        WebResponseContent webResponse = new WebResponseContent();
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMES_EquipRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public MES_EquipService(
            IMES_EquipRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }

        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="saveDataModel"></param>
        /// <returns></returns>
        public override WebResponseContent Add(SaveModel saveDataModel)
        {
            string mesg = string.Empty;
            //此处saveModel是从前台提交的原生数据，可对数据进修改过滤
            AddOnExecute = (SaveModel saveModel) =>
            {
                return webResponse.OK(mesg);
            };
            AddOnExecuting = (MES_Equip order, object list) =>
            {
                return webResponse.OK();
            };
            //此方法中已开启了事务，如果在此方法中做其他数据库操作，请不要再开启事务
            // 在保存数据库后的操作，此时已进行数据提交，但未提交事务，如果返回false，则会回滚提交
            AddOnExecuted = (MES_Equip order, object list) =>
            {
                return webResponse.OK(mesg);
            };
            return base.Add(saveDataModel);
        }

        /// <summary>
        /// 编辑操作
        /// </summary>
        /// <param name="saveModel"></param>
        /// <returns></returns>
        public override WebResponseContent Update(SaveModel saveModel)
        {
            //注意：如果要给其他字段设置值，请在此处设置,如：（代码生成器上将字段编辑行设置为0，然后点生成model）
            //saveModel.MainData["字段"] = "值";

            //此处saveModel是从前台提交的原生数据，可对数据进修改过滤
            UpdateOnExecute = (SaveModel model) =>
            {
                return webResponse.OK();

            };
            //编辑方法保存数据库前处理
            UpdateOnExecuting = (MES_Equip order, object addList, object updateList, List<object> delKeys) =>
            {
                return webResponse.OK();
            };
            //编辑方法保存数据库后处理
            //此方法中已开启了事务，如果在此方法中做其他数据库操作，请不要再开启事务
            // 在保存数据库后的操作，此时已进行数据提交，但未提交事务，如果返回false，则会回滚提交
            UpdateOnExecuted = (MES_Equip order, object addList, object updateList, List<object> delKeys) =>
            {
                return webResponse.OK();
            };
            return base.Update(saveModel);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="keys">删除的行的主键</param>
        /// <param name="delList">删除时是否将明细也删除</param>
        /// <returns></returns>
        public override WebResponseContent Del(object[] keys, bool delList = true)
        {
            //删除前处理
            //删除的行的主键
            DelOnExecuting = (object[] _keys) =>
            {
                return webResponse.OK();
            };
            //删除后处理
            //删除的行的主键
            DelOnExecuted = (object[] _keys) =>
            {
                return webResponse.OK();
            };
            return base.Del(keys, delList);
        }

    }
}
