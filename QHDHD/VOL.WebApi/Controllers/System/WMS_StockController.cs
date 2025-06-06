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
    [Route("api/WMS_Stock")]
    [PermissionTable(Name = "WMS_Stock")]
    public partial class WMS_StockController : ApiBaseController<IWMS_StockService>
    {
    public WMS_StockController(IWMS_StockService service)
    : base(service)
    {
    }
    }
    }

