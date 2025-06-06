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
    public partial class WMS_PutStockService : ServiceBase<WMS_PutStock, IWMS_PutStockRepository>
    , IWMS_PutStockService, IDependency
    {
    public static IWMS_PutStockService Instance
    {
    get { return AutofacContainerModule.GetService<IWMS_PutStockService>
        (); } }
        }
        }
