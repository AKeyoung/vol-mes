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
    public partial class MES_Report_WorkRepository : RepositoryBase<MES_Report_Work>
    , IMES_Report_WorkRepository
    {
        public MES_Report_WorkRepository(VOLContext dbContext) : base(dbContext)
        {

        }
        public static IMES_Report_WorkRepository Instance
        {
            get
            {
                return AutofacContainerModule.GetService<IMES_Report_WorkRepository>();
            }
        }
    }
}
