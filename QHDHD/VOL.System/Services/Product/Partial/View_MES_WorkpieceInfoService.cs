/********************************
 *
 * 文 件 名:   $safeitemname$
 * 创 建 者：  $username$
 * 创建时间：  $time$
 *
********************************/
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using System.Linq;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using VOL.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using VOL.System.IRepositories;

namespace VOL.System.Services
{
    public partial class View_MES_WorkpieceInfoService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IView_MES_WorkpieceInfoRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public View_MES_WorkpieceInfoService(
            IView_MES_WorkpieceInfoRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }

        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="saveDataModel"></param>
        /// <returns></returns>
        public override WebResponseContent Add(SaveModel saveDataModel)
        {
            return MES_WorkpieceInfoService.Instance.Add(saveDataModel);
        }

        /// <summary>
        /// 编辑操作
        /// </summary>
        /// <param name="saveModel"></param>
        /// <returns></returns>
        public override WebResponseContent Update(SaveModel saveModel)
        {
            return MES_WorkpieceInfoService.Instance.Update(saveModel);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="delList"></param>
        /// <returns></returns>
        public override WebResponseContent Del(object[] keys, bool delList = true)
        {
            return MES_WorkpieceInfoService.Instance.Del(keys);
        }

        /// <summary>
        /// 更具订单编号获取工单
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public View_MES_WorkpieceInfo GetInfo(string code)
        {
            return _repository.Find(x => x.order_no == code).FirstOrDefault();
        }
    }
}
