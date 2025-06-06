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
    [Route("api/WMS_PutStock")]
    [PermissionTable(Name = "WMS_PutStock")]
    public partial class WMS_PutStockController : ApiBaseController<IWMS_PutStockService>
    {
    public WMS_PutStockController(IWMS_PutStockService service)
    : base(service)
    {
    }
    }
    }

