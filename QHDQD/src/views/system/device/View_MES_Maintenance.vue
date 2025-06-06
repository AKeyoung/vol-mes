<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/device/View_MES_Maintenance.js此处编写
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
    import extend from "@/extension/system/device/View_MES_Maintenance.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'Id',
                footer: "Foots",
                cnName: '设备维修',
                name: 'device/View_MES_Maintenance',
                url: "/View_MES_Maintenance/",
                sortName: "Id"
            });
            const editFormFields = ref({"DeviceId":"","Brand":"","Model":"","EquipSn":"","Supplier":"","MainType":"","Remarks":"","MainFiles":""});
            const editFormOptions = ref([[{"dataKey":"设备列表","data":[],"title":"设备名称","required":true,"field":"DeviceId","type":"remoteSearch"},
                               {"title":"品牌","field":"Brand","disabled":true},
                               {"title":"规格信号","field":"Model","disabled":true}],
                              [{"title":"序列号","field":"EquipSn","disabled":true},
                               {"title":"供应商","field":"Supplier","disabled":true},
                               {"title":"维修类型","required":true,"field":"MainType"}],
                              [{"title":"备注","field":"Remarks","colSize":12,"type":"textarea"}],
                              [{"title":"相关图片","required":true,"field":"MainFiles","type":"file"}]]);
            const searchFormFields = ref({"Name":"","EquipSn":"","Brand":"","Model":"","Supplier":""});
            const searchFormOptions = ref([[{"title":"设备名称","field":"Name","type":"like"},{"title":"序列号","field":"EquipSn","type":"like"},{"title":"品牌","field":"Brand","type":"like"}],[{"title":"规格信号","field":"Model","type":"like"},{"title":"供应商","field":"Supplier","type":"like"}]]);
            const columns = ref([{field:'Id',title:'Id',type:'int',width:110,hidden:true,require:true,align:'left'},
                       {field:'DeviceId',title:'设备名称',type:'int',bind:{ key:'设备列表',data:[]},width:110,hidden:true,require:true,align:'left'},
                       {field:'Name',title:'设备名称',type:'string',width:120,readonly:true,align:'left',sort:true},
                       {field:'EquipSn',title:'序列号',type:'string',width:120,readonly:true,align:'left'},
                       {field:'Brand',title:'品牌',type:'string',width:120,readonly:true,align:'left'},
                       {field:'Model',title:'规格信号',type:'string',width:120,readonly:true,align:'left'},
                       {field:'Supplier',title:'供应商',type:'string',width:120,readonly:true,align:'left'},
                       {field:'SupplierAddress',title:'供应商地址',type:'string',width:220,align:'left'},
                       {field:'SupplierPhone',title:'供应商电话',type:'string',width:110,align:'left'},
                       {field:'MainType',title:'维修类型',type:'string',width:180,require:true,align:'left'},
                       {field:'Remarks',title:'备注',type:'string',width:220,align:'left'},
                       {field:'MainFiles',title:'相关图片',type:'file',width:220,require:true,align:'left'},
                       {field:'ReserveOne',title:'ReserveOne',type:'string',width:220,hidden:true,align:'left'},
                       {field:'ReserveTwo',title:'ReserveTwo',type:'string',width:220,hidden:true,align:'left'},
                       {field:'ReserveThree',title:'ReserveThree',type:'string',width:220,hidden:true,align:'left'},
                       {field:'ReserveFour',title:'ReserveFour',type:'string',width:220,hidden:true,align:'left'},
                       {field:'ReserveFive',title:'ReserveFive',type:'string',width:220,hidden:true,align:'left'},
                       {field:'UpdateUser',title:'UpdateUser',type:'string',width:110,hidden:true,align:'left'},
                       {field:'CreateUser',title:'CreateUser',type:'string',width:110,hidden:true,align:'left'},
                       {field:'UpdateTime',title:'UpdateTime',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'CreateTime',title:'CreateTime',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'EquipID',title:'EquipID',type:'int',width:110,hidden:true,align:'left'},
                       {field:'InDate',title:'InDate',type:'datetime',width:150,hidden:true,align:'left',sort:true}]);
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
