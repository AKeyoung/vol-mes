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
    public partial class MES_WorkpieceInfoDetailRepository : RepositoryBase<MES_WorkpieceInfoDetail>
    , IMES_WorkpieceInfoDetailRepository
    {
    public MES_WorkpieceInfoDetailRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IMES_WorkpieceInfoDetailRepository Instance
    {
    get {  return AutofacContainerModule.GetService<IMES_WorkpieceInfoDetailRepository>
        (); } }
        }
        }
