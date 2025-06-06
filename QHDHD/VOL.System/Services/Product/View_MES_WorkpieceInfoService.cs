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
    public partial class View_MES_WorkpieceInfoService : ServiceBase<View_MES_WorkpieceInfo, IView_MES_WorkpieceInfoRepository>
    , IView_MES_WorkpieceInfoService, IDependency
    {
    public static IView_MES_WorkpieceInfoService Instance
    {
    get { return AutofacContainerModule.GetService<IView_MES_WorkpieceInfoService>
        (); } }
        }
        }
