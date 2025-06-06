<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/warehouse/WMS_PutStock.js此处编写
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
    import extend from "@/extension/system/warehouse/WMS_PutStock.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '出库管理',
                name: 'warehouse/WMS_PutStock',
                url: "/WMS_PutStock/",
                sortName: "ID"
            });
            const editFormFields = ref({"putno":"","type":"","static":"","InoutType":"","DeliveryOrg":"","DeliveryTime":"","remark":""});
            const editFormOptions = ref([[{"title":"单据编号","field":"putno"},
                               {"title":"单据类型","field":"type","type":"number"},
                               {"title":"单据状态","field":"static","type":"number"}],
                              [{"title":"发货组织","field":"DeliveryOrg"},
                               {"title":"发货时间","field":"DeliveryTime","type":"datetime"},
                               {"title":"出入库类型","field":"InoutType"}],
                              [{"title":"备注","field":"remark","type":"editor"}]]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'ID',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Sguid',title:'SGUID',type:'string',width:220,hidden:true,align:'left'},
                       {field:'Tenant',title:'租户id',type:'string',width:220,hidden:true,align:'left'},
                       {field:'putno',title:'单据编号',type:'string',width:220,align:'left',sort:true},
                       {field:'type',title:'单据类型',type:'int',width:110,align:'left'},
                       {field:'InoutType',title:'出入库类型',type:'string',width:220,align:'left'},
                       {field:'static',title:'单据状态',type:'int',width:110,align:'left'},
                       {field:'DeliveryOrg',title:'发货组织',type:'string',width:220,align:'left'},
                       {field:'DeliveryTime',title:'发货时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'remark',title:'备注',type:'string',width:220,align:'left'},
                       {field:'CreatedBy',title:'创建人',type:'int',width:110,align:'left'},
                       {field:'CreatedTime',title:'创建时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'UpdatedBy',title:'更新人',type:'int',width:110,align:'left'},
                       {field:'UpdatedTime',title:'更新时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'isQualified',title:'isQualified',type:'bool',width:110,hidden:true,align:'left'},
                       {field:'CustomerId',title:'CustomerId',type:'string',width:220,hidden:true,align:'left'},
                       {field:'Dataownership',title:'Dataownership',type:'string',width:220,hidden:true,align:'left'}]);
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
