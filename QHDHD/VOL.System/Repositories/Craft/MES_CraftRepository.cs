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
    public partial class MES_CraftRepository : RepositoryBase<MES_Craft>
    , IMES_CraftRepository
    {
    public MES_CraftRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IMES_CraftRepository Instance
    {
    get {  return AutofacContainerModule.GetService<IMES_CraftRepository>
        (); } }
        }
        }
