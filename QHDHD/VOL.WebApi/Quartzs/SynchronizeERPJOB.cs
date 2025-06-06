using Quartz;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using VOL.Core.BaseProvider;
using VOL.Entity.DomainModels;
using VOL.Core.Configuration;
using YourNamespace;
using System.Data;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using VOL.System.Services;
using Microsoft.Extensions.DependencyInjection;

namespace VOL.WebApi.Quartzs
{
    public class SynchronizeERPJOB : IJob
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        public SynchronizeERPJOB(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }
        public Task Execute(IJobExecutionContext context)
        {
            try
            {
                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    Pac_Routing_OpService wpic = scope.ServiceProvider.GetRequiredService<Pac_Routing_OpService>();
                    OracleDataAccess dbhel = new OracleDataAccess();
                    string sql = "SELECT * FROM Pac_Routing_Op";
                    DataTable dtb = dbhel.ExecuteQuery(sql);
                    foreach (DataRow item in dtb.Rows)
                    {

                    }
                    return Task.Delay(0);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
