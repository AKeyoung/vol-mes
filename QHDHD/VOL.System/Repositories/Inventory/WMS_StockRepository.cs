/********************************
 *
 * 文 件 名:   $safeitemname$
 * 创 建 者：  $username$
 * 创建时间：  $time$
 *
********************************/
using VOL.System.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.System.Repositories
{
    public partial class WMS_StockRepository : RepositoryBase<WMS_Stock>
    , IWMS_StockRepository
    {
    public WMS_StockRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IWMS_StockRepository Instance
    {
    get {  return AutofacContainerModule.GetService<IWMS_StockRepository>
        (); } }
        }
        }
