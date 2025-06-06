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
    public partial class MES_ConserveRepository : RepositoryBase<MES_Conserve>
    , IMES_ConserveRepository
    {
    public MES_ConserveRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IMES_ConserveRepository Instance
    {
    get {  return AutofacContainerModule.GetService<IMES_ConserveRepository>
        (); } }
        }
        }
