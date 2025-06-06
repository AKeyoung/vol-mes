<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/craft/MES_Attachment.js此处编写
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
    import extend from "@/extension/system/craft/MES_Attachment.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'Id',
                footer: "Foots",
                cnName: 'DNC程序管理',
                name: 'craft/MES_Attachment',
                url: "/MES_Attachment/",
                sortName: "ModifyDate"
            });
            const editFormFields = ref({"Url":"","Name":"","Description":"","IsEnable":""});
            const editFormOptions = ref([[{"title":"附件","field":"Url","type":"file"}],
                              [{"title":"附件名称","required":true,"field":"Name"}],
                              [{"title":"备注","field":"Description","type":"textarea"}],
                              [{"dataKey":"enable","data":[],"title":"是否启用","required":true,"field":"IsEnable","type":"radio"}]]);
            const searchFormFields = ref({"Name":"","Creator":"","CreateDate":""});
            const searchFormOptions = ref([[{"title":"附件名称","field":"Name","type":"text"},{"title":"创建人","field":"Creator","type":"text"},{"title":"创建时间","field":"CreateDate","type":"datetime"}]]);
            const columns = ref([{field:'Id',title:'ID',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Name',title:'附件名称',type:'string',link:true,sort:true,width:180,require:true,align:'left',sort:true},
                       {field:'Url',title:'附件',type:'file',width:220,align:'left'},
                       {field:'IsEnable',title:'是否启用',type:'byte',bind:{ key:'enable',data:[]},width:110,require:true,align:'left'},
                       {field:'Description',title:'备注',type:'string',width:220,align:'left'},
                       {field:'CreateID',title:'创建人id',type:'int',width:100,hidden:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:100,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',sort:true,width:150,align:'left',sort:true},
                       {field:'ModifyID',title:'修改人id',type:'int',width:100,hidden:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:100,align:'left'},
                       {field:'ModifyDate',title:'修改时间',type:'datetime',sort:true,width:150,align:'left',sort:true}]);
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
