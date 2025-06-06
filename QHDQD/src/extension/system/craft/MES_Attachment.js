//此js文件是用来自定义扩展业务代码，可以扩展一些自定义页面或者重新配置生成的代码
import { h } from 'vue';

let extension = {
  components: {
    //查询界面扩展组件
    gridHeader: '',
    gridBody: '',
    gridFooter: '',
    //新建、编辑弹出框扩展组件
    modelHeader: '',
    modelBody: '',
    modelRight: '',
    modelFooter: ''
  },
  tableAction: '', //指定某张表的权限(这里填写表名,默认不用填写)
  buttons: { view: [], box: [], detail: [] }, //扩展的按钮
  methods: {
    //下面这些方法可以保留也可以删除
    onInit() {

      // 设置IsEnable字段为开关方式
      this.columns.forEach(row => {
        if (row.field === "IsEnable") {
          // 强制设置为编辑列，类型为switch
          row.edit = { type: "switch", keep: true };
          // 手动绑定数据源
          row.bind = { key: "enable", data: [{ key: 0, value: '禁用' }, { key: 1, value: '启用' }] };
          // 绑定switch切换事件
          let $this = this;
          row.onChange = (options, rowData, _columns) => {
            // 构造更新请求的参数
            let params = {
                "mainData": {
                  "Url": rowData.Url,
                  "Name": rowData.Name,
                  "Description": rowData.Description,
                  "IsEnable": options, // 根据status转换启用状态,
                  "Id": rowData.Id
                },
                "detailData": null,
                "delKeys": null
              };

            // 发送更新请求
            $this.http.post('api/MES_Attachment/update', params, true).then(result => {
              if (!result.status) {
                $this.$message.error(result.message);
              } else {
                if(options==1){
                  $this.$message.success('已启用');
                }else{
                  $this.$message.info('已停用');
                }
              }
            }).catch(error => {
              console.error('更新失败:', error);
              $this.$message.error('更新失败，请稍后再试');
            });
          };
        }
      });

      // this.columns.forEach(row => {
      //   if (row.field === 'Url') {
      //     row.render = (rowIndex,rowData, columnIndex) => {
      //       // 根据IsEnable的值决定是否显示链接
      //       if (rowData.row.IsEnable === 1) {
      //         return h('a', {
      //           target: '_blank',
      //           class: 't-file',
      //           style: { marginRight: '8px' },
      //           textContent: rowData.row.Name || '无'
      //         });
      //       } else {
      //         // IsEnable=0时只显示文本
      //          return rowData.row.Name || '无';
      //       }
      //     };
      //    }
      // });

      //上传文件后自动填写文件名
      this.editFormOptions.forEach(x => {
        x.forEach(item => {

          if (item.field == "Url") {
            // 上传后
            item.uploadAfter = (file, fn) => {
              let fileName = '';
              // 优先从fn[0].name获取文件名
              if (fn && Array.isArray(fn) && fn[0] && fn[0].name) {
                fileName = fn[0].name;
              } else if (file && file.data && typeof file.data === 'string') {
                // 取最后的文件夹或文件名
                fileName = file.data.split(/[\\/]/).filter(Boolean).pop();
              }
              if (fileName) {
                this.editFormFields.Name = fileName;
              }
              return true;
            }
          }
        })
      });

    },
    onInited() {
      //框架初始化配置后
      //如果要配置明细表,在此方法操作
      //this.detailOptions.columns.forEach(column=>{ });
    },
    searchBefore(param) {
      //界面查询前,可以给param.wheres添加查询参数
      //返回false，则不会执行查询
      return true;
    },
    searchAfter(result) {
      //查询后，result返回的查询数据,可以在显示到表格前处理表格的值
      return true;
    },
    addBefore(formData) {
      //新建保存前formData为对象，包括明细表，可以给给表单设置值，自己输出看formData的值
      return true;
    },
    updateBefore(formData) {
      //编辑保存前formData为对象，包括明细表、删除行的Id
      return true;
    },
    rowClick({ row, column, event }) {
      //查询界面点击行事件
      // this.$refs.table.$refs.table.toggleRowSelection(row); //单击行时选中当前行;
    },
    modelOpenAfter(row) {
      //获取当前弹出框是新建还是编辑状态
      let isEDIT = this.currentAction == this.const.EDIT;
      //设置默认值
      if (!isEDIT) {
        this.editFormFields.IsEnable = "1";
       }
       this.editFormOptions.forEach(item => {
          item.forEach(x => {
                  //如果是新建 设置为只读
                  if (x.field == "IsEnable") {
                      //disabled是editFormOptions的动态属性
                       x.disabled=!isEDIT
                  }
              });
      });
    }
  }
};
export default extension;
