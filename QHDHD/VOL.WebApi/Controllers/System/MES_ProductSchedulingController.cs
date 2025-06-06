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
    [Route("api/MES_ProductScheduling")]
    [PermissionTable(Name = "MES_ProductScheduling")]
    public partial class MES_ProductSchedulingController : ApiBaseController<IMES_ProductSchedulingService>
    {
    public MES_ProductSchedulingController(IMES_ProductSchedulingService service)
    : base(service)
    {
    }
    }
    }

