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
    public partial class QHD_materialRepository : RepositoryBase<QHD_material>
    , IQHD_materialRepository
    {
    public QHD_materialRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IQHD_materialRepository Instance
    {
    get {  return AutofacContainerModule.GetService<IQHD_materialRepository>
        (); } }
        }
        }
