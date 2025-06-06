<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/product/MES_WorkpieceInfoDetail.js此处编写
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
    import extend from "@/extension/system/product/MES_WorkpieceInfoDetail.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'Id',
                footer: "Foots",
                cnName: '生产工单明细',
                name: 'product/MES_WorkpieceInfoDetail',
                url: "/MES_WorkpieceInfoDetail/",
                sortName: "Id"
            });
            const editFormFields = ref({"ToolNumber":"","ToolTypeNumber":"","ToolDiameter":"","ToolInstallationLength":"","RotationalSpeed":"","FeedRate":"","Allowance":"","ToolCompensationNumber":"","ProcessingTime":"","ZDepth":"","Remarks":""});
            const editFormOptions = ref([[{"title":"刀号","field":"ToolNumber"},
                               {"title":"刀型编号","field":"ToolTypeNumber"},
                               {"title":"刀具直径","field":"ToolDiameter","type":"decimal"},
                               {"title":"装刀长度","field":"ToolInstallationLength","type":"decimal"},
                               {"title":"转速","field":"RotationalSpeed","type":"number"},
                               {"title":"进给","field":"FeedRate","type":"decimal"},
                               {"title":"余量","field":"Allowance","type":"decimal"},
                               {"title":"刀补号","field":"ToolCompensationNumber"},
                               {"title":"时间","field":"ProcessingTime","type":"decimal"},
                               {"title":"Z深","field":"ZDepth","type":"decimal"},
                               {"title":"备注","field":"Remarks","type":"textarea"}]]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'Id',title:'主键，自增',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'ToolNumber',title:'刀号',type:'string',width:110,align:'left',sort:true},
                       {field:'ToolTypeNumber',title:'刀型编号',type:'string',width:110,align:'left'},
                       {field:'ToolDiameter',title:'刀具直径',type:'decimal',width:110,align:'left'},
                       {field:'ToolInstallationLength',title:'装刀长度',type:'decimal',width:110,align:'left'},
                       {field:'RotationalSpeed',title:'转速',type:'int',width:110,align:'left'},
                       {field:'FeedRate',title:'进给',type:'decimal',width:110,align:'left'},
                       {field:'Allowance',title:'余量',type:'decimal',width:110,align:'left'},
                       {field:'ToolCompensationNumber',title:'刀补号',type:'string',width:110,align:'left'},
                       {field:'ProcessingTime',title:'时间',type:'decimal',width:110,align:'left'},
                       {field:'ZDepth',title:'Z深',type:'decimal',width:110,align:'left'},
                       {field:'Remarks',title:'备注',type:'string',width:180,align:'left'},
                       {field:'CreateTime',title:'创建时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'UpdateTime',title:'修改时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'CreateUser',title:'创建人',type:'string',width:110,hidden:true,align:'left'},
                       {field:'UpdateUser',title:'修改人',type:'string',width:110,hidden:true,align:'left'},
                       {field:'WIID',title:'主表 ID',type:'int',width:110,hidden:true,align:'left'}]);
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
