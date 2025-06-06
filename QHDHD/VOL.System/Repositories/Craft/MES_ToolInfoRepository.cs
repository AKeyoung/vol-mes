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
    public partial class MES_ToolInfoRepository : RepositoryBase<MES_ToolInfo>
    , IMES_ToolInfoRepository
    {
    public MES_ToolInfoRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IMES_ToolInfoRepository Instance
    {
    get {  return AutofacContainerModule.GetService<IMES_ToolInfoRepository>
        (); } }
        }
        }
