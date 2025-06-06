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
    public partial class View_FMS_cnc1daokuService : ServiceBase<View_FMS_cnc1daoku, IView_FMS_cnc1daokuRepository>
    , IView_FMS_cnc1daokuService, IDependency
    {
    public static IView_FMS_cnc1daokuService Instance
    {
    get { return AutofacContainerModule.GetService<IView_FMS_cnc1daokuService>
        (); } }
        }
        }
