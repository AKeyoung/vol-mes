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
    public partial class WMS_InOutTakeService : ServiceBase<WMS_InOutTake, IWMS_InOutTakeRepository>
    , IWMS_InOutTakeService, IDependency
    {
    public static IWMS_InOutTakeService Instance
    {
    get { return AutofacContainerModule.GetService<IWMS_InOutTakeService>
        (); } }
        }
        }
