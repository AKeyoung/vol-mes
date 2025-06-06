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
    [Route("api/WMS_InOutTake")]
    [PermissionTable(Name = "WMS_InOutTake")]
    public partial class WMS_InOutTakeController : ApiBaseController<IWMS_InOutTakeService>
    {
    public WMS_InOutTakeController(IWMS_InOutTakeService service)
    : base(service)
    {
    }
    }
    }

