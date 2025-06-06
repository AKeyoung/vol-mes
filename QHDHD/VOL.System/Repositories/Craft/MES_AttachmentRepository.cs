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
    public partial class MES_AttachmentRepository : RepositoryBase<MES_Attachment>
    , IMES_AttachmentRepository
    {
    public MES_AttachmentRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IMES_AttachmentRepository Instance
    {
    get {  return AutofacContainerModule.GetService<IMES_AttachmentRepository>
        (); } }
        }
        }
