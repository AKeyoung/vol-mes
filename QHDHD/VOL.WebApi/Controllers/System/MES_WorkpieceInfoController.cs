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
    [Route("api/MES_WorkpieceInfo")]
    [PermissionTable(Name = "MES_WorkpieceInfo")]
    public partial class MES_WorkpieceInfoController : ApiBaseController<IMES_WorkpieceInfoService>
    {
    public MES_WorkpieceInfoController(IMES_WorkpieceInfoService service)
    : base(service)
    {
    }
    }
    }

