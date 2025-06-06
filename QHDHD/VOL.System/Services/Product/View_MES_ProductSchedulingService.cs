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
    public partial class View_MES_ProductSchedulingService : ServiceBase<View_MES_ProductScheduling, IView_MES_ProductSchedulingRepository>
    , IView_MES_ProductSchedulingService, IDependency
    {
    public static IView_MES_ProductSchedulingService Instance
    {
    get { return AutofacContainerModule.GetService<IView_MES_ProductSchedulingService>
        (); } }
        }
        }
