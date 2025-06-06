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
    [Route("api/MES_Report_Work")]
    [PermissionTable(Name = "MES_Report_Work")]
    public partial class MES_Report_WorkController : ApiBaseController<IMES_Report_WorkService>
    {
    public MES_Report_WorkController(IMES_Report_WorkService service)
    : base(service)
    {
    }
    }
    }

