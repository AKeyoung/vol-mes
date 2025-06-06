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
    [Route("api/MES_WorkpieceInfoDetail")]
    [PermissionTable(Name = "MES_WorkpieceInfoDetail")]
    public partial class MES_WorkpieceInfoDetailController : ApiBaseController<IMES_WorkpieceInfoDetailService>
    {
    public MES_WorkpieceInfoDetailController(IMES_WorkpieceInfoDetailService service)
    : base(service)
    {
    }
    }
    }

