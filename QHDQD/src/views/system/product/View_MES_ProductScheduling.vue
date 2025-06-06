<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/product/View_MES_ProductScheduling.js此处编写
 -->
<template>
    <view-grid ref="grid"
               :columns="columns"
               :detail="detail"
               :editFormFields="editFormFields"
               :editFormOptions="editFormOptions"
               :searchFormFields="searchFormFields"
               :searchFormOptions="searchFormOptions"
               :table="table"
               :extend="extend">
    </view-grid>
</template>
<script>
    import extend from "@/extension/system/product/View_MES_ProductScheduling.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'Id',
                footer: "Foots",
                cnName: '订单排产',
                name: 'product/View_MES_ProductScheduling',
                url: "/View_MES_ProductScheduling/",
                sortName: "Id"
            });
            const editFormFields = ref({});
            const editFormOptions = ref([]);
            const searchFormFields = ref({"ProCode":"","Status":"","ProgramNum":"","ProductionSchedulingTime":""});
            const searchFormOptions = ref([[{"title":"排程编号","field":"ProCode"},{"dataKey":"排产状态","data":[],"title":"状态","field":"Status","type":"select"},{"title":"程序号","field":"ProgramNum"},{"title":"排程时间","field":"ProductionSchedulingTime","type":"date"}]]);
            const columns = ref([{field:'Id',title:'Id',type:'int',width:110,hidden:true,require:true,align:'left'},
                       {field:'OP_ID',title:'OP_ID',type:'int',width:110,hidden:true,align:'left'},
                       {field:'ProCode',title:'排程编号',type:'string',width:160,align:'left',sort:true},
                       {field:'Status',title:'状态',type:'int',bind:{ key:'排产状态',data:[]},width:110,align:'left'},
                       {field:'ProgramNum',title:'程序号',type:'string',width:160,align:'left'},
                       {field:'SortNum',title:'排序号',type:'int',width:160,align:'left'},
                       {field:'ProductionSchedulingTime',title:'排程时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'Enable',title:'是否暂停',type:'int',bind:{ key:'enable',data:[]},width:120,align:'left'},
                       {field:'UpdateTime',title:'UpdateTime',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'CreateUser',title:'CreateUser',type:'string',width:220,hidden:true,align:'left'},
                       {field:'CreateTime',title:'CreateTime',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'company_code',title:'公司名',type:'string',width:220,align:'left'},
                       {field:'rs_id',title:'rs_id',type:'string',width:110,hidden:true,align:'left'},
                       {field:'order_no',title:'任务号',type:'string',width:160,align:'left'},
                       {field:'op_no',title:'工序号',type:'long',width:160,align:'left'},
                       {field:'op_name',title:'工序名',type:'string',width:160,align:'left'},
                       {field:'item_code',title:'物料编码',type:'string',width:160,align:'left'},
                       {field:'item_name',title:'物料名称',type:'string',width:220,align:'left'},
                       {field:'item_model',title:'规格型号',type:'string',width:220,align:'left'},
                       {field:'item_norm',title:'图号',type:'string',width:160,align:'left'},
                       {field:'plan_qty',title:'计划数量',type:'float',width:160,align:'left'},
                       {field:'work_no',title:'工作令号',type:'string',width:160,align:'left'},
                       {field:'plan_no',title:'计划号',type:'string',width:160,align:'left'},
                       {field:'customer_code',title:'客户编码',type:'string',width:160,align:'left'},
                       {field:'customer_name',title:'客户名称',type:'string',width:220,align:'left'},
                       {field:'unit_code',title:'计量单位',type:'string',width:160,align:'left'},
                       {field:'unit_name',title:'计量名称',type:'string',width:160,align:'left'},
                       {field:'dept_code',title:'责任部门编码',type:'string',width:160,align:'left'},
                       {field:'dept_name',title:'责任部门名称',type:'string',width:220,align:'left'},
                       {field:'wc_code',title:'工位编码',type:'string',width:160,align:'left'},
                       {field:'wc_name',title:'工位名称',type:'string',width:220,align:'left'},
                       {field:'start_date',title:'计划开始时间',type:'string',width:160,align:'left'},
                       {field:'Adjustment',title:'调整原因',type:'string',width:180,align:'left'},
                       {field:'Remarks',title:'备注',type:'string',width:220,align:'left'}]);
            const detail = ref({
                cnName: "#detailCnName",
                table: "#detailTable",
                columns: [],
                sortName: "",
                key: ""
            });
            return {
                table,
                extend,
                editFormFields,
                editFormOptions,
                searchFormFields,
                searchFormOptions,
                columns,
                detail,
            };
        },
    });
</script>
