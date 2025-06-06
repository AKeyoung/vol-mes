using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Quartz.Spi;
using Quartz;
using System.Threading.Tasks;
using System;
using VOL.Core.Quartz;
using Microsoft.Extensions.DependencyInjection;
using VOL.Core.Utilities;

namespace VOL.WebApi.Quartzs
{
    public static class CustomWorking
    {

        /// <summary>
        /// 初始化作业
        /// </summary>
        /// <param name="applicationBuilder"></param>
        /// <param name="env"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseCustomQuartz(this IApplicationBuilder applicationBuilder, IWebHostEnvironment env)
        {
            IServiceProvider services = applicationBuilder.ApplicationServices;
            ISchedulerFactory _schedulerFactory = services.GetService<ISchedulerFactory>();
            try
            {
                //MyAddJob(_schedulerFactory, jobFactory: services.GetService<IJobFactory>()).GetAwaiter().GetResult();
                ProductionSch(_schedulerFactory, jobFactory: services.GetService<IJobFactory>()).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"作业启动异常:{ex.Message + ex.StackTrace}");
            }
            return applicationBuilder;
        }

        /// <summary>
        /// 添加作业
        /// </summary>
        /// <param name="taskOptions"></param>
        /// <param name="schedulerFactory"></param>
        /// <param name="init">是否初始化,否=需要重新生成配置文件，是=不重新生成配置文件</param>
        /// <returns></returns>
        public static async Task<object> MyAddJob(ISchedulerFactory schedulerFactory, IJobFactory jobFactory = null)
        {

            string msg = null;
            try
            {
                string guid = Guid.NewGuid().ToString();
                IJobDetail job = JobBuilder.Create<SynchronizeERPJOB>()
               .WithIdentity(guid, "custom").Build();
                ITrigger trigger = TriggerBuilder.Create()
                   .WithIdentity(guid, "custom")
                   // .st()
                   .WithDescription("同步ERP数据")
                   //.WithCronSchedule("0 0/30 * * * ?")// 每分钟执行
                   .WithCronSchedule("0 0 */1 * * ?")// 每小时执行一次
                   .Build();

                IScheduler scheduler = await schedulerFactory.GetScheduler();

                if (jobFactory == null)
                {
                    jobFactory = HttpContext.Current.RequestServices.GetService<IJobFactory>();
                }

                if (jobFactory != null)
                {
                    scheduler.JobFactory = jobFactory;
                }

                await scheduler.ScheduleJob(job, trigger);
                await scheduler.Start();
            }
            catch (Exception ex)
            {
                msg = $"作业启动异常:同步ERP数据,{ex.Message}";
                Console.WriteLine(msg);
                QuartzFileHelper.Error(msg);
                return new { status = false, msg = ex.Message };
            }
            return new { status = true };
        }

        /// <summary>
        /// 订单自动排产
        /// </summary>
        /// <param name="taskOptions"></param>
        /// <param name="schedulerFactory"></param>
        /// <param name="init">是否初始化,否=需要重新生成配置文件，是=不重新生成配置文件</param>
        /// <returns></returns>
        public static async Task<object> ProductionSch(ISchedulerFactory schedulerFactory, IJobFactory jobFactory = null)
        {

            string msg = null;
            try
            {
                string guid = Guid.NewGuid().ToString();
                IJobDetail job = JobBuilder.Create<ProductionSchedulingJOB>()
               .WithIdentity(guid, "produ").Build();
                ITrigger trigger = TriggerBuilder.Create()
                   .WithIdentity(guid, "produ")
                   // .st()
                   .WithDescription("订单排产")
                   //.WithCronSchedule("0 0/30 * * * ?")// 每半小时执行
                   .WithCronSchedule("0 0/15 * * * ? ")// 每15分执行一次.
                   .Build();

                IScheduler scheduler = await schedulerFactory.GetScheduler();

                if (jobFactory == null)
                {
                    jobFactory = HttpContext.Current.RequestServices.GetService<IJobFactory>();
                }

                if (jobFactory != null)
                {
                    scheduler.JobFactory = jobFactory;
                }

                await scheduler.ScheduleJob(job, trigger);
                await scheduler.Start();
            }
            catch (Exception ex)
            {
                msg = $"作业启动异常:同步ERP数据,{ex.Message}";
                Console.WriteLine(msg);
                QuartzFileHelper.Error(msg);
                return new { status = false, msg = ex.Message };
            }
            return new { status = true };
        }
    }
}
