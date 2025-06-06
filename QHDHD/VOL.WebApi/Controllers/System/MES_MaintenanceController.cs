/********************************
 *
 * 文 件 名:   $safeitemname$
 * 创 建 者：  $username$
 * 创建时间：  $time$
 *
********************************/
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.System.IServices;
namespace VOL.System.Controllers
{
    [Route("api/MES_Maintenance")]
    [PermissionTable(Name = "MES_Maintenance")]
    public partial class MES_MaintenanceController : ApiBaseController<IMES_MaintenanceService>
    {
    public MES_MaintenanceController(IMES_MaintenanceService service)
    : base(service)
    {
    }
    }
    }

