/********************************
 *
 * 文 件 名:   $safeitemname$
 * 创 建 者：  $username$
 * 创建时间：  $time$
 *
********************************/
using VOL.System.IRepositories;
using VOL.System.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.System.Services
{
    public partial class MES_ToolInfoService : ServiceBase<MES_ToolInfo, IMES_ToolInfoRepository>
    , IMES_ToolInfoService, IDependency
    {
    public static IMES_ToolInfoService Instance
    {
    get { return AutofacContainerModule.GetService<IMES_ToolInfoService>
        (); } }
        }
        }
