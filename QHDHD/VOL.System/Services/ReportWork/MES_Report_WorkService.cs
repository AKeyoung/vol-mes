/********************************
 *
 * 文 件 名:   $safeitemname$
 * 创 建 者：  $username$
 * 创建时间：  $time$
 *
********************************/
using VOL.System.IRepositories;
using VOL.System.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.System.Services
{
    public partial class MES_Report_WorkService : ServiceBase<MES_Report_Work, IMES_Report_WorkRepository>
    , IMES_Report_WorkService, IDependency
    {
    public static IMES_Report_WorkService Instance
    {
    get { return AutofacContainerModule.GetService<IMES_Report_WorkService>
        (); } }
        }
        }
