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
    public partial class MES_CraftService : ServiceBase<MES_Craft, IMES_CraftRepository>
    , IMES_CraftService, IDependency
    {
    public static IMES_CraftService Instance
    {
    get { return AutofacContainerModule.GetService<IMES_CraftService>
        (); } }
        }
        }
