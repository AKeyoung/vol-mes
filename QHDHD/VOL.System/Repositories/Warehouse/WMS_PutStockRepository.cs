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
    public partial class WMS_PutStockRepository : RepositoryBase<WMS_PutStock>
    , IWMS_PutStockRepository
    {
    public WMS_PutStockRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IWMS_PutStockRepository Instance
    {
    get {  return AutofacContainerModule.GetService<IWMS_PutStockRepository>
        (); } }
        }
        }
