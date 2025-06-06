/********************************
 *
 * 文 件 名:   $safeitemname$
 * 创 建 者：  $username$
 * 创建时间：  $time$
 *
********************************/
using VOL.System.IRepositories;
using VOL.System.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.System.Services
{
    public partial class MES_MaintenanceService : ServiceBase<MES_Maintenance, IMES_MaintenanceRepository>
    , IMES_MaintenanceService, IDependency
    {
    public static IMES_MaintenanceService Instance
    {
    get { return AutofacContainerModule.GetService<IMES_MaintenanceService>
        (); } }
        }
        }
