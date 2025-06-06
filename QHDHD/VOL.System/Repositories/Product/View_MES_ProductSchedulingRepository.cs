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
    public partial class View_MES_ProductSchedulingRepository : RepositoryBase<View_MES_ProductScheduling>
    , IView_MES_ProductSchedulingRepository
    {
    public View_MES_ProductSchedulingRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IView_MES_ProductSchedulingRepository Instance
    {
    get {  return AutofacContainerModule.GetService<IView_MES_ProductSchedulingRepository>
        (); } }
        }
        }
