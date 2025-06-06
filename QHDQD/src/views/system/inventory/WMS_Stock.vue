<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/inventory/WMS_Stock.js此处编写
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
    import extend from "@/extension/system/inventory/WMS_Stock.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '库存管理',
                name: 'inventory/WMS_Stock',
                url: "/WMS_Stock/",
                sortName: "ID"
            });
            const editFormFields = ref({});
            const editFormOptions = ref([]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'WarehouseId',title:'存放仓库',type:'int',bind:{ key:'仓库库位',data:[]},width:80,align:'left',sort:true},
                       {field:'BatchesId',title:'批次号',type:'string',width:220,require:true,align:'left'},
                       {field:'SkuId',title:'货物类型',type:'int',bind:{ key:'物料编号',data:[]},width:80,require:true,align:'left'},
                       {field:'qty',title:'库存总量',type:'decimal',width:110,align:'left'},
                       {field:'static',title:'状态',type:'string',width:220,align:'left'},
                       {field:'ID',title:'id',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'SGUID',title:'SGUID',type:'string',width:220,hidden:true,align:'left'},
                       {field:'Tenant',title:'租户id',type:'string',width:220,hidden:true,align:'left'},
                       {field:'CreatedBy',title:'创建人',type:'int',width:80,align:'left'},
                       {field:'CreatedTime',title:'创建时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'UpdatedBy',title:'更新人',type:'int',width:80,align:'left'},
                       {field:'UpdatedTime',title:'更新时间',type:'datetime',width:150,align:'left',sort:true},
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
