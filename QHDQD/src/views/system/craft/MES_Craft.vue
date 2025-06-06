<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/craft/MES_Craft.js此处编写
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
    import extend from "@/extension/system/craft/MES_Craft.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'Id',
                footer: "Foots",
                cnName: '工艺信息',
                name: 'craft/MES_Craft',
                url: "/MES_Craft/",
                sortName: "Id"
            });
            const editFormFields = ref({"Name":"","Content":"","Require":"","Enable":"","OrderIndex":"","GuidanceFile":""});
            const editFormOptions = ref([[{"title":"工艺名称","required":true,"field":"Name"},
                               {"title":"工艺内容","required":true,"field":"Content"}],
                              [{"title":"技术要求","required":true,"field":"Require"},
                               {"title":"是否启用","required":true,"field":"Enable"}],
                              [{"title":"排序标志","required":true,"field":"OrderIndex","type":"number"},
                               {"title":"指导文件","required":true,"field":"GuidanceFile","type":"file"}]]);
            const searchFormFields = ref({"Name":"","Content":"","Require":"","Enable":""});
            const searchFormOptions = ref([[{"title":"工艺名称","field":"Name"},{"title":"工艺内容","field":"Content"},{"title":"技术要求","field":"Require"},{"title":"是否启用","field":"Enable"}]]);
            const columns = ref([{field:'Id',title:'主键',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Name',title:'工艺名称',type:'string',width:110,require:true,align:'left',sort:true},
                       {field:'OrderIndex',title:'排序标志',type:'int',width:110,require:true,align:'left'},
                       {field:'Content',title:'工艺内容',type:'string',width:220,require:true,align:'left'},
                       {field:'Require',title:'技术要求',type:'string',width:220,require:true,align:'left'},
                       {field:'GuidanceFile',title:'指导文件',type:'file',width:180,require:true,align:'left'},
                       {field:'Enable',title:'是否启用',type:'string',width:110,require:true,align:'left'},
                       {field:'WorkStaitionId',title:'工位ID',type:'int',width:110,hidden:true,align:'left'},
                       {field:'UpdateUser',title:'更新人',type:'string',width:120,hidden:true,align:'left'},
                       {field:'CreateUser',title:'创建人',type:'string',width:120,hidden:true,align:'left'},
                       {field:'UpdateTime',title:'更新时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'CreateTime',title:'创建时间',type:'datetime',width:150,hidden:true,align:'left',sort:true}]);
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
