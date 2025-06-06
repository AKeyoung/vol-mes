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
    public partial class QHD_materialService : ServiceBase<QHD_material, IQHD_materialRepository>
    , IQHD_materialService, IDependency
    {
    public static IQHD_materialService Instance
    {
    get { return AutofacContainerModule.GetService<IQHD_materialService>
        (); } }
        }
        }
