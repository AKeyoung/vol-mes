//此js文件是用来自定义扩展业务代码，可以扩展一些自定义页面或者重新配置生成的代码

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
    getFormOption(field) {
        let option;
        this.editFormOptions.forEach(x => {
            x.forEach(item => {
                if (item.field == field) {
                    option = item;
                }
            })
        })
        return option;
    },
     //下面这些方法可以保留也可以删除
    onInit() { 
        this.editFormOptions.forEach(x => {
            x.forEach(item => {
                if (item.field == 'FixtureAndMachiningZeroDiagram') {
                    item.type = 'file';//可以指定上传文件类型img/file/excel
                    item.fileTypes = ['jpg', 'png', 'gif', 'jpeg', 'pdf'];//指定文件类型
                    //设置上传图片字段100%宽度
                    // item.colSize = 12;
                    //启用多图上传(默认单图)
                    item.multiple = true;
                    //启用自动上传(默认自动上传)
                    item.autoUpload = true;
                    //最多可以上传3张照片
                    item.maxFile = 5;
                    //限制图片大小，默认3M
                    item.maxSize = 25;
                    //选择文件时
                    item.onChange = (files) => {
                        //此处不返回true，会中断代码执行
                        return true;
                    }
                    //上传前
                    item.uploadBefore = (files) => {
                        return true;
                    }
                    //上传后
                    item.uploadAfter = (files) => {
                        return true;
                    }
                }else if (item.field == 'FilesUrl') {
                    item.type = 'excel';//可以指定上传文件类型img/file/excel
                    // item.fileTypes = ['jpg', 'png', 'gif', 'jpeg', 'pdf'];//指定文件类型
                    //设置上传图片字段100%宽度
                    // item.colSize = 12;
                    //启用多图上传(默认单图)
                    item.multiple = true;
                    //启用自动上传(默认自动上传)
                    item.autoUpload = true;
                    //最多可以上传3张照片
                    item.maxFile = 1;
                    //限制图片大小，默认3M
                    item.maxSize = 50;
                    //选择文件时
                    item.onChange = (files) => {
                        //此处不返回true，会中断代码执行
                        return true;
                    }
                    //上传前
                    item.uploadBefore = (files) => {
                        return true;
                    }
                    //上传后
                    item.uploadAfter = (files) => {
                        return true;
                    }
                }
            })
        })
        var proj = this.getFormOption('OrderId')
            proj.onChange = (val, option) => {
                this.editFormFields.OrderIdtemp = option.value1;
                this.editFormFields.OrderId = option.key;
            }
            this.columns.forEach(x => {
                if (x.field == "order_no") {
                    x.link = true
                }
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
        if (this.currentAction != 'Add') {
            this.editFormFields.OrderIdtemp = row.order_no;
        }
    }
  }
};
export default extension;
