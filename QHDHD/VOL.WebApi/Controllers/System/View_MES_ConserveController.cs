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
    [Route("api/View_MES_Conserve")]
    [PermissionTable(Name = "View_MES_Conserve")]
    public partial class View_MES_ConserveController : ApiBaseController<IView_MES_ConserveService>
    {
    public View_MES_ConserveController(IView_MES_ConserveService service)
    : base(service)
    {
    }
    }
    }

