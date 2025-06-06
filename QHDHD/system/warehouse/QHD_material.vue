<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/warehouse/QHD_material.js此处编写
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
    import extend from "@/extension/system/warehouse/QHD_material.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '入库管理',
                name: 'warehouse/QHD_material',
                url: "/QHD_material/",
                sortName: "id"
            });
            const editFormFields = ref({});
            const editFormOptions = ref([]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'id',title:'id',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'BatchNumber',title:'批次号',type:'string',width:120,align:'left',sort:true},
                       {field:'Type',title:'类型',type:'int',width:80,align:'left'},
                       {field:'Name',title:'刀具名称',type:'string',width:120,align:'left'},
                       {field:'SN',title:'SN码',type:'string',width:120,align:'left'},
                       {field:'Model',title:'刀具型号',type:'string',width:120,align:'left'},
                       {field:'IsAssembly',title:'IsAssembly',type:'string',width:120,align:'left'},
                       {field:'WarehouseName',title:'仓库名称',type:'string',width:120,align:'left'},
                       {field:'CreateTime',title:'创建时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'Static',title:'状态',type:'string',width:120,align:'left'},
                       {field:'Qty',title:'入库数量',type:'decimal',width:110,align:'left'},
                       {field:'Sguid',title:'Sguid',type:'string',width:120,align:'left'},
                       {field:'WarehouseId',title:'仓库id',type:'string',width:120,align:'left'},
                       {field:'StuId',title:'物料id',type:'string',width:120,align:'left'}]);
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
