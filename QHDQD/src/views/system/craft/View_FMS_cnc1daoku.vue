<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/craft/View_FMS_cnc1daoku.js此处编写
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
    import extend from "@/extension/system/craft/View_FMS_cnc1daoku.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'RowId',
                footer: "Foots",
                cnName: '刀具使用寿命',
                name: 'craft/View_FMS_cnc1daoku',
                url: "/View_FMS_cnc1daoku/",
                sortName: "RowId"
            });
            const editFormFields = ref({});
            const editFormOptions = ref([]);
            const searchFormFields = ref({"KnifePositionNature":"","KnifeTypeNumber":"","ToolNumber":"","ToolCategory":"","ProcessingMaterial":[],"ToolStatus":""});
            const searchFormOptions = ref([[{"title":"刀型编号","field":"KnifeTypeNumber"},{"title":"刀具编号","field":"ToolNumber"},{"dataKey":"ToolCategory","data":[],"title":"刀具类别","field":"ToolCategory","type":"select"}],[{"dataKey":"KnifePositionNature","data":[],"title":"刀位性质","field":"KnifePositionNature","type":"select"},{"dataKey":"ProcessingMaterial","data":[],"title":"加工材质","field":"ProcessingMaterial","type":"selectList"},{"dataKey":"ToolStatus","data":[],"title":"刀具状态","field":"ToolStatus","type":"select"}]]);
            const columns = ref([{field:'ID',title:'ID',type:'int',width:110,hidden:true,require:true,align:'left'},
                       {field:'DataSource',title:'所在位置',type:'string',width:110,align:'left',sort:true},
                       {field:'RowId',title:'RowId',type:'string',sort:true,width:120,hidden:true,require:true,align:'left'},
                       {field:'RobotNo',title:'机器编号',type:'int',width:80,align:'left'},
                       {field:'KnifePositionNumber',title:'刀位号',type:'string',width:110,align:'left'},
                       {field:'KnifePositionNature',title:'刀位性质',type:'string',bind:{ key:'KnifePositionNature',data:[]},width:120,align:'left'},
                       {field:'KnifeTypeNumber',title:'刀型编号',type:'string',width:120,align:'left'},
                       {field:'ToolNumber',title:'刀具编号',type:'string',width:120,align:'left'},
                       {field:'ToolCategory',title:'刀具类别',type:'string',bind:{ key:'ToolCategory',data:[]},width:120,align:'left'},
                       {field:'ToolSpecification',title:'刀具规格',type:'string',width:120,align:'left'},
                       {field:'HandleSpecification',title:'刀柄规格',type:'string',width:120,align:'left'},
                       {field:'ClampingLength',title:'装夹长度',type:'string',width:120,align:'left'},
                       {field:'ProcessingMaterial',title:'加工材质',type:'string',bind:{ key:'ProcessingMaterial',data:[]},width:120,align:'left'},
                       {field:'UsageFunction',title:'使用功能',type:'string',width:120,align:'left'},
                       {field:'ToolCompensationH',title:'刀补号H',type:'string',width:120,align:'left'},
                       {field:'ToolCompensationD',title:'刀补号D',type:'string',width:120,align:'left'},
                       {field:'MonitoringMethod',title:'监控方式',type:'string',width:120,align:'left'},
                       {field:'ReplacementMethod',title:'更换方式',type:'string',width:120,align:'left'},
                       {field:'SettingValue',title:'设定值',type:'string',width:120,align:'left'},
                       {field:'ActualValue',title:'实际值',type:'string',width:120,align:'left'},
                       {field:'ResidualValue',title:'剩余值',type:'string',width:110,align:'left'},
                       {field:'LoadValue',title:'负载值',type:'string',width:120,align:'left'},
                       {field:'ToolSettingRequirements',title:'对刀要求',type:'string',width:120,align:'left'},
                       {field:'ToolStatus',title:'刀具状态',type:'string',bind:{ key:'ToolStatus',data:[]},width:120,align:'left'},
                       {field:'PositionStatus',title:'仓位状态',type:'string',width:120,hidden:true,align:'left'}]);
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
