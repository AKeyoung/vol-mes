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
    [Route("api/View_MES_ProductScheduling")]
    [PermissionTable(Name = "View_MES_ProductScheduling")]
    public partial class View_MES_ProductSchedulingController : ApiBaseController<IView_MES_ProductSchedulingService>
    {
    public View_MES_ProductSchedulingController(IView_MES_ProductSchedulingService service)
    : base(service)
    {
    }
    }
    }

