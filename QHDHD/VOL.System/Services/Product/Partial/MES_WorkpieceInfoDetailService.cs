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
using System.Net;

namespace VOL.System.Services
{
    public partial class MES_WorkpieceInfoDetailService
    {
        WebResponseContent webResponse = new WebResponseContent();
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMES_WorkpieceInfoDetailRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public MES_WorkpieceInfoDetailService(
            IMES_WorkpieceInfoDetailRepository dbRepository,
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
            //此处saveModel是从前台提交的原生数据，可对数据进修改过滤
            AddOnExecute = (SaveModel saveModel) =>
            {
                //如果返回false,后面代码不会再执行
                return webResponse.OK();
            };
            // 在保存数据库前的操作，所有数据都验证通过了，这一步执行完就执行数据库保存
            AddOnExecuting = (MES_WorkpieceInfoDetail order, object list) =>
            {
                return webResponse.OK();
            };

            //此方法中已开启了事务，如果在此方法中做其他数据库操作，请不要再开启事务
            // 在保存数据库后的操作，此时已进行数据提交，但未提交事务，如果返回false，则会回滚提交
            AddOnExecuted = (MES_WorkpieceInfoDetail order, object list) =>
            {
                return webResponse.OK();
            };

            return base.Add(saveDataModel);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="saveModel"></param>
        /// <returns></returns>
        public override WebResponseContent Update(SaveModel saveModel)
        {
            UpdateOnExecute = (SaveModel model) =>
            {
                return webResponse.OK();
            };

            //编辑方法保存数据库前处理
            UpdateOnExecuting = (MES_WorkpieceInfoDetail order, object addList, object updateList, List<object> delKeys) =>
            {
                return webResponse.OK();
            };

            //编辑方法保存数据库后处理
            //此方法中已开启了事务，如果在此方法中做其他数据库操作，请不要再开启事务
            // 在保存数据库后的操作，此时已进行数据提交，但未提交事务，如果返回false，则会回滚提交
            UpdateOnExecuted = (MES_WorkpieceInfoDetail order, object addList, object updateList, List<object> delKeys) =>
            {
                return webResponse.OK();
            };

            return base.Update(saveModel);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="keys">删除的行的主键</param>
        /// <param name="delList">删除时是否将明细也删除</param>
        /// <returns></returns>
        public override WebResponseContent Del(object[] keys, bool delList = true)
        {
            //删除前处理
            //删除的行的主键
            DelOnExecuting = (object[] _keys) =>
            {
                return webResponse.OK();
            };
            //删除后处理
            //删除的行的主键
            DelOnExecuted = (object[] _keys) =>
            {
                return webResponse.OK();
            };
            return base.Del(keys, delList);
        }

        public List<MES_WorkpieceInfoDetail> GetDeInfo(int OrId)
        {
            return _repository.Find(x => x.WIID == OrId);
        }
    }
}
