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
    [Route("api/MES_Craft")]
    [PermissionTable(Name = "MES_Craft")]
    public partial class MES_CraftController : ApiBaseController<IMES_CraftService>
    {
    public MES_CraftController(IMES_CraftService service)
    : base(service)
    {
    }
    }
    }

