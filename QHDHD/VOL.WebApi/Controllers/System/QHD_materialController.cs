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
    [Route("api/QHD_material")]
    [PermissionTable(Name = "QHD_material")]
    public partial class QHD_materialController : ApiBaseController<IQHD_materialService>
    {
    public QHD_materialController(IQHD_materialService service)
    : base(service)
    {
    }
    }
    }

