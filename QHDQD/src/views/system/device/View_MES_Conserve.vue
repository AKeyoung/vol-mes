<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/device/View_MES_Conserve.js此处编写
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
    import extend from "@/extension/system/device/View_MES_Conserve.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'Id',
                footer: "Foots",
                cnName: '设备保养',
                name: 'device/View_MES_Conserve',
                url: "/View_MES_Conserve/",
                sortName: "Id"
            });
            const editFormFields = ref({"DeviceId":"","EquipSn":"","Brand":"","Model":"","ConPlan":"","ConType":"","StartTime":"","EndTime":"","Remarks":"","FilesUrl":""});
            const editFormOptions = ref([[{"dataKey":"设备列表","data":[],"title":"设备名称","required":true,"field":"DeviceId","type":"remoteSearch"},
                               {"title":"序列号","field":"EquipSn","disabled":true},
                               {"title":"品牌","field":"Brand","disabled":true},
                               {"title":"规格型号","field":"Model","disabled":true}],
                              [{"title":"保养计划","field":"ConPlan"},
                               {"title":"保养类型","field":"ConType"},
                               {"title":"开始时间","required":true,"field":"StartTime","type":"date"},
                               {"title":"结束时间","required":true,"field":"EndTime","type":"date"}],
                              [{"title":"保养内容","required":true,"field":"Remarks","colSize":12,"type":"textarea"}],
                              [{"title":"保养文件","required":true,"field":"FilesUrl","type":"file"}]]);
            const searchFormFields = ref({"Name":"","EquipSn":"","Brand":"","Model":"","Supplier":"","ConPlan":"","ConType":""});
            const searchFormOptions = ref([[{"title":"设备名称","field":"Name","type":"like"},{"title":"序列号","field":"EquipSn","type":"like"},{"title":"品牌","field":"Brand","type":"like"},{"title":"规格型号","field":"Model","type":"like"}],[{"title":"供应商","field":"Supplier","type":"like"},{"title":"保养计划","field":"ConPlan","type":"like"},{"title":"保养类型","field":"ConType","type":"like"}]]);
            const columns = ref([{field:'Id',title:'Id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'DeviceId',title:'设备名称',type:'string',bind:{ key:'设备列表',data:[]},width:120,hidden:true,require:true,align:'left'},
                       {field:'Name',title:'设备名称',type:'string',width:120,align:'left',sort:true},
                       {field:'EquipSn',title:'序列号',type:'string',width:120,readonly:true,align:'left'},
                       {field:'Brand',title:'品牌',type:'string',width:120,readonly:true,align:'left'},
                       {field:'Model',title:'规格型号',type:'string',width:120,readonly:true,align:'left'},
                       {field:'Supplier',title:'供应商',type:'string',width:120,readonly:true,align:'left'},
                       {field:'SupplierAddress',title:'供应商地址',type:'string',width:220,align:'left'},
                       {field:'SupplierPhone',title:'供应商电话',type:'string',width:110,align:'left'},
                       {field:'InDate',title:'入场时间',type:'date',width:150,align:'left',sort:true},
                       {field:'ConPlan',title:'保养计划',type:'string',width:220,align:'left'},
                       {field:'ConType',title:'保养类型',type:'string',width:180,align:'left'},
                       {field:'StartTime',title:'开始时间',type:'date',width:150,require:true,align:'left',sort:true},
                       {field:'EndTime',title:'结束时间',type:'date',width:150,require:true,align:'left',sort:true},
                       {field:'Remarks',title:'保养内容',type:'string',width:220,require:true,align:'left'},
                       {field:'ReserveOne',title:'ReserveOne',type:'string',width:220,hidden:true,align:'left'},
                       {field:'ReserveTwo',title:'ReserveTwo',type:'string',width:220,hidden:true,align:'left'},
                       {field:'ReserveThree',title:'ReserveThree',type:'string',width:220,hidden:true,align:'left'},
                       {field:'ReserveFour',title:'ReserveFour',type:'string',width:220,hidden:true,align:'left'},
                       {field:'ReserveFive',title:'ReserveFive',type:'string',width:220,hidden:true,align:'left'},
                       {field:'UpdateUser',title:'更新人',type:'string',width:110,hidden:true,align:'left'},
                       {field:'CreateUser',title:'创建人',type:'string',width:110,hidden:true,align:'left'},
                       {field:'UpdateTime',title:'更新时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'CreateTime',title:'创建时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'FilesUrl',title:'保养文件',type:'file',width:220,require:true,align:'left'},
                       {field:'EquipID',title:'EquipID',type:'int',width:80,hidden:true,align:'left'}]);
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
