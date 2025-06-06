/********************************
 *
 * 文 件 名:   $safeitemname$
 * 创 建 者：  $username$
 * 创建时间：  $time$
 *
********************************/
using VOL.Core.BaseProvider;
using VOL.Entity.DomainModels;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using System.Collections.Generic;
namespace VOL.System.IServices
{
    public partial interface IPac_Routing_OpService
    {
        List<Pac_Routing_Op> GetAllInfo();
    }
 }
