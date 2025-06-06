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
    [Route("api/View_FMS_cnc1daoku")]
    [PermissionTable(Name = "View_FMS_cnc1daoku")]
    public partial class View_FMS_cnc1daokuController : ApiBaseController<IView_FMS_cnc1daokuService>
    {
    public View_FMS_cnc1daokuController(IView_FMS_cnc1daokuService service)
    : base(service)
    {
    }
    }
    }

