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
using OfficeOpenXml;
using System.Collections.Generic;
using System.Xml.Linq;

namespace VOL.System.Services
{
    public partial class MES_CraftService
    {
        WebResponseContent webResponse = new WebResponseContent();
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMES_CraftRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public MES_CraftService(
            IMES_CraftRepository dbRepository,
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
        /// 导出
        /// </summary>
        /// <param name="pageData"></param>
        /// <returns></returns>
        public override WebResponseContent Export(PageDataOptions pageData)
        {
            //设置最大导出的数量
            Limit = 1000;
            //指定导出的字段(2020.05.07)
            ExportColumns = x => new {
                x.Name,
                x.Content,
                x.Require,
                x.OrderIndex,
                x.Enable
            };

            //查询要导出的数据后，在生成excel文件前处理
            //list导出的实体，ignore过滤不导出的字段
            ExportOnExecuting = (List<MES_Craft> list, List<string> ignore) =>
            {
                return webResponse.OK();
            };

            return base.Export(pageData);
        }

        /// <summary>
        /// 下载模板(导入时弹出框中的下载模板)(2020.05.07)
        /// </summary>
        /// <returns></returns>
        public override WebResponseContent DownLoadTemplate()
        {
            //指定导出模板的字段,如果不设置DownLoadTemplateColumns，默认导出查所有页面上能看到的列(2020.05.07)
            DownLoadTemplateColumns = x => new {
                x.Name,
                x.Content,
                x.Require,
                x.OrderIndex,
                x.Enable
            };
            return base.DownLoadTemplate();
        }

        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public override WebResponseContent Import(List<IFormFile> files)
        {
            //(2020.05.07)
            //设置导入的字段(如果指定了上面导出模板的字段，这里配置应该与上面DownLoadTemplate方法里配置一样)
            //如果不设置导入的字段DownLoadTemplateColumns,默认显示所有界面上所有可以看到的字段
            DownLoadTemplateColumns = x => new {
                x.Name,
                x.Content,
                x.Require,
                x.OrderIndex,
                x.Enable
            };
            return base.Import(files);
        }
    }
}
