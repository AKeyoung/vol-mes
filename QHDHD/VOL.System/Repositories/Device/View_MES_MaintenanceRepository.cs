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
    public partial class View_MES_MaintenanceRepository : RepositoryBase<View_MES_Maintenance>
    , IView_MES_MaintenanceRepository
    {
    public View_MES_MaintenanceRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IView_MES_MaintenanceRepository Instance
    {
    get {  return AutofacContainerModule.GetService<IView_MES_MaintenanceRepository>
        (); } }
        }
        }
