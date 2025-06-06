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
    public partial class View_FMS_cnc1daokuRepository : RepositoryBase<View_FMS_cnc1daoku>
    , IView_FMS_cnc1daokuRepository
    {
    public View_FMS_cnc1daokuRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IView_FMS_cnc1daokuRepository Instance
    {
    get {  return AutofacContainerModule.GetService<IView_FMS_cnc1daokuRepository>
        (); } }
        }
        }
