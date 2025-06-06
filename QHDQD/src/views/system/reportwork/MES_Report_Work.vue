<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/reportwork/MES_Report_Work.js此处编写
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
    import extend from "@/extension/system/reportwork/MES_Report_Work.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'Report_ID',
                footer: "Foots",
                cnName: '报工管理',
                name: 'reportwork/MES_Report_Work',
                url: "/MES_Report_Work/",
                sortName: "Report_ID"
            });
            const editFormFields = ref({});
            const editFormOptions = ref([]);
            const searchFormFields = ref({"Work_Order_No":"","Process_No":"","Equipment_ID":"","Start_Time":"","End_Time":"","Report_Status":""});
            const searchFormOptions = ref([[{"title":"工单编号","field":"Work_Order_No"},{"title":"工序编号","field":"Process_No"},{"title":"设备编号","field":"Equipment_ID"}],[{"title":"开工时间","field":"Start_Time","type":"date"},{"title":"完工时间","field":"End_Time","type":"date"},{"title":"报工状态","field":"Report_Status","type":"number"}]]);
            const columns = ref([{field:'Report_ID',title:'报工记录ID',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Work_Order_No',title:'工单编号',type:'string',width:110,align:'left',sort:true},
                       {field:'Process_No',title:'工序编号',type:'string',width:110,align:'left'},
                       {field:'User_ID',title:'员工编号',type:'string',width:110,align:'left'},
                       {field:'Equipment_ID',title:'设备编号',type:'string',width:110,align:'left'},
                       {field:'Shift',title:'班次',type:'string',width:110,align:'left'},
                       {field:'Qty',title:'数量',type:'int',width:110,align:'left'},
                       {field:'Good_Qty',title:'良品数量',type:'int',width:110,align:'left'},
                       {field:'Defective_Qty',title:'次品数量',type:'int',width:110,align:'left'},
                       {field:'Scrap_Qty',title:'废品数量',type:'int',width:110,align:'left'},
                       {field:'Start_Time',title:'开工时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'End_Time',title:'完工时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'Report_Status',title:'报工状态',type:'byte',width:110,align:'left'},
                       {field:'Audit_Time',title:'审核时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'Auditor',title:'审核人',type:'string',width:180,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:220,align:'left'},
                       {field:'CreateID',title:'创建人ID',type:'int',width:100,hidden:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:100,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'ModifyID',title:'修改人ID',type:'int',width:100,hidden:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:100,align:'left'},
                       {field:'ModifyDate',title:'修改时间',type:'datetime',width:150,align:'left',sort:true}]);
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
