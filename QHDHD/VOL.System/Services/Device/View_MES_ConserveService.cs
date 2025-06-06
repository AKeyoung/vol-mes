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
    public partial class View_MES_ConserveService : ServiceBase<View_MES_Conserve, IView_MES_ConserveRepository>
    , IView_MES_ConserveService, IDependency
    {
    public static IView_MES_ConserveService Instance
    {
    get { return AutofacContainerModule.GetService<IView_MES_ConserveService>
        (); } }
        }
        }
