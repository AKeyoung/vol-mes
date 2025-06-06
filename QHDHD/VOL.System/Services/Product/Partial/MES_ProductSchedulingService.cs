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
using System.Collections.Generic;
using System;

namespace VOL.System.Services
{
    public partial class MES_ProductSchedulingService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMES_ProductSchedulingRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public MES_ProductSchedulingService(
            IMES_ProductSchedulingRepository dbRepository,
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
        /// 获取时间排序第一个
        /// </summary>
        /// <returns></returns>
        public MES_ProductScheduling getOrderByTime()
        {
            return _repository.Find(x => true).OrderByDescending(x => x.CreateTime).FirstOrDefault();
        }
    }
}
