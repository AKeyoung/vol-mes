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
    [Route("api/View_MES_WorkpieceInfo")]
    [PermissionTable(Name = "View_MES_WorkpieceInfo")]
    public partial class View_MES_WorkpieceInfoController : ApiBaseController<IView_MES_WorkpieceInfoService>
    {
    public View_MES_WorkpieceInfoController(IView_MES_WorkpieceInfoService service)
    : base(service)
    {
    }
    }
    }

