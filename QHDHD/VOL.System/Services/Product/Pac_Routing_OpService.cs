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
    public partial class Pac_Routing_OpService : ServiceBase<Pac_Routing_Op, IPac_Routing_OpRepository>
    , IPac_Routing_OpService, IDependency
    {
    public static IPac_Routing_OpService Instance
    {
    get { return AutofacContainerModule.GetService<IPac_Routing_OpService>
        (); } }
        }
        }
