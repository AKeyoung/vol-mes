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
    [Route("api/Pac_Routing_Op")]
    [PermissionTable(Name = "Pac_Routing_Op")]
    public partial class Pac_Routing_OpController : ApiBaseController<IPac_Routing_OpService>
    {
    public Pac_Routing_OpController(IPac_Routing_OpService service)
    : base(service)
    {
    }
    }
    }

