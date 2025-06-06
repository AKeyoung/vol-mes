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
    public partial class WMS_StockService : ServiceBase<WMS_Stock, IWMS_StockRepository>
    , IWMS_StockService, IDependency
    {
    public static IWMS_StockService Instance
    {
    get { return AutofacContainerModule.GetService<IWMS_StockService>
        (); } }
        }
        }
