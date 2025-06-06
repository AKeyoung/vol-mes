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
    [Route("api/MES_Conserve")]
    [PermissionTable(Name = "MES_Conserve")]
    public partial class MES_ConserveController : ApiBaseController<IMES_ConserveService>
    {
    public MES_ConserveController(IMES_ConserveService service)
    : base(service)
    {
    }
    }
    }

