<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/task/WMS_InOutTake.js此处编写
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
    import extend from "@/extension/system/task/WMS_InOutTake.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '单据管理',
                name: 'task/WMS_InOutTake',
                url: "/WMS_InOutTake/",
                sortName: "id"
            });
            const editFormFields = ref({"ApplicationOrder":"","ApplicationTime":"","ApplicationPerson":"","ApplicationDepart":"","ExpectedOutTime":"","ApplicationQty":"","DescriptionPurpose":"","Remarks":""});
            const editFormOptions = ref([[{"title":"申请单号","field":"ApplicationOrder"},
                               {"title":"申请日期","field":"ApplicationTime","type":"datetime"}],
                              [{"title":"申请人","field":"ApplicationPerson"},
                               {"title":"申请部门","field":"ApplicationDepart"}],
                              [{"title":"预计出库日期","field":"ExpectedOutTime","type":"datetime"},
                               {"title":"申请数量","field":"ApplicationQty","type":"decimal"}],
                              [{"title":"用途说明","field":"DescriptionPurpose"}],
                              [{"title":"备注","field":"Remarks","type":"editor"}]]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'id',title:'id',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'ApplicationOrder',title:'申请单号',type:'string',width:120,align:'left',sort:true},
                       {field:'ApplicationTime',title:'申请日期',type:'datetime',width:150,align:'left',sort:true},
                       {field:'ApplicationPerson',title:'申请人',type:'string',width:120,align:'left'},
                       {field:'ApplicationDepart',title:'申请部门',type:'string',width:220,align:'left'},
                       {field:'ExpectedOutTime',title:'预计出库日期',type:'datetime',width:150,align:'left',sort:true},
                       {field:'ApplicationQty',title:'申请数量',type:'decimal',width:110,align:'left'},
                       {field:'DescriptionPurpose',title:'用途说明',type:'string',width:220,align:'left'},
                       {field:'Remarks',title:'备注',type:'string',width:220,align:'left'},
                       {field:'Static',title:'状态',type:'int',width:80,align:'left'},
                       {field:'Sguid',title:'Sguid',type:'string',width:110,hidden:true,align:'left'},
                       {field:'InOutTakeStatic',title:'InOutTakeStatic',type:'int',width:80,hidden:true,align:'left'}]);
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
