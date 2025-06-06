<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/craft/MES_ToolInfo.js此处编写
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
    import extend from "@/extension/system/craft/MES_ToolInfo.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'Id',
                footer: "Foots",
                cnName: '刀具管理',
                name: 'craft/MES_ToolInfo',
                url: "/MES_ToolInfo/",
                sortName: "Id"
            });
            const editFormFields = ref({});
            const editFormOptions = ref([]);
            const searchFormFields = ref({"KnifePositionNumber":"","KnifePositionNature":"","KnifeTypeNumber":"","ToolNumber":"","ToolCategory":"","ToolSpecification":""});
            const searchFormOptions = ref([[{"title":"刀位号","field":"KnifePositionNumber"},{"title":"刀位性质","field":"KnifePositionNature"},{"title":"刀型编号","field":"KnifeTypeNumber"}],[{"title":"刀具编号","field":"ToolNumber"},{"title":"刀具类别","field":"ToolCategory"},{"title":"刀具规格","field":"ToolSpecification"}]]);
            const columns = ref([{field:'Id',title:'主键',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'KnifePositionNumber',title:'刀位号',type:'string',width:160,align:'left',sort:true},
                       {field:'KnifePositionNature',title:'刀位性质',type:'string',width:160,align:'left'},
                       {field:'KnifeTypeNumber',title:'刀型编号',type:'string',width:160,align:'left'},
                       {field:'ToolNumber',title:'刀具编号',type:'string',width:160,align:'left'},
                       {field:'ToolCategory',title:'刀具类别',type:'string',width:160,align:'left'},
                       {field:'ToolSpecification',title:'刀具规格',type:'string',width:160,align:'left'},
                       {field:'HandleSpecification',title:'刀柄规格',type:'string',width:160,align:'left'},
                       {field:'ClampingLength',title:'装夹长度',type:'string',width:160,align:'left'},
                       {field:'ProcessingMaterial',title:'加工材质',type:'string',width:160,align:'left'},
                       {field:'UsageFunction',title:'使用功能',type:'string',width:160,align:'left'},
                       {field:'ToolCompensationH',title:'刀补号H',type:'string',width:160,align:'left'},
                       {field:'ToolCompensationD',title:'刀补号D',type:'string',width:160,align:'left'},
                       {field:'MonitoringMethod',title:'监控方式',type:'string',width:160,align:'left'},
                       {field:'ReplacementMethod',title:'更换方式',type:'string',width:160,align:'left'},
                       {field:'SettingValue',title:'设定值',type:'string',width:160,align:'left'},
                       {field:'ActualValue',title:'实际值',type:'string',width:160,align:'left'},
                       {field:'ToolSettingRequirements',title:'对刀要求',type:'string',width:160,align:'left'},
                       {field:'ToolStatus',title:'刀具状态',type:'string',width:160,align:'left'},
                       {field:'CreateTime',title:'创建时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'UpdateTime',title:'修改时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'CreateUser',title:'创建人',type:'string',width:110,hidden:true,align:'left'},
                       {field:'UpdateUser',title:'修改人',type:'string',width:110,hidden:true,align:'left'}]);
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
