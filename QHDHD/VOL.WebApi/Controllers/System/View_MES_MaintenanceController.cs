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
    [Route("api/View_MES_Maintenance")]
    [PermissionTable(Name = "View_MES_Maintenance")]
    public partial class View_MES_MaintenanceController : ApiBaseController<IView_MES_MaintenanceService>
    {
    public View_MES_MaintenanceController(IView_MES_MaintenanceService service)
    : base(service)
    {
    }
    }
    }

