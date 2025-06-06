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
    [Route("api/MES_Attachment")]
    [PermissionTable(Name = "MES_Attachment")]
    public partial class MES_AttachmentController : ApiBaseController<IMES_AttachmentService>
    {
    public MES_AttachmentController(IMES_AttachmentService service)
    : base(service)
    {
    }
    }
    }

