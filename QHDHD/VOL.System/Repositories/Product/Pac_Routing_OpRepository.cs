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
    public partial class Pac_Routing_OpRepository : RepositoryBase<Pac_Routing_Op>
    , IPac_Routing_OpRepository
    {
    public Pac_Routing_OpRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IPac_Routing_OpRepository Instance
    {
    get {  return AutofacContainerModule.GetService<IPac_Routing_OpRepository>
        (); } }
        }
        }
