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
    [Route("api/MES_DataGatherAndon")]
    [PermissionTable(Name = "MES_DataGatherAndon")]
    public partial class MES_DataGatherAndonController : ApiBaseController<IMES_DataGatherAndonService>
    {
    public MES_DataGatherAndonController(IMES_DataGatherAndonService service)
    : base(service)
    {
    }
    }
    }

