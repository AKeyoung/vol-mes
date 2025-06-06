<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/device/MES_Conserve.js此处编写
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
    import extend from "@/extension/system/device/MES_Conserve.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'Id',
                footer: "Foots",
                cnName: '设备保养',
                name: 'device/MES_Conserve',
                url: "/MES_Conserve/",
                sortName: "Id"
            });
            const editFormFields = ref({"DeviceId":"","SN":"","Brand":"","Model":"","Supplier":"","SupplierPhone":"","ConPlan":"","ConType":"","StartTime":"","EndTime":"","SupplierAddress":"","Remarks":"","FilesUrl":""});
            const editFormOptions = ref([[{"dataKey":"设备列表","data":[],"title":"设备名称","field":"DeviceId","type":"remoteSearch"},
                               {"title":"序列号","field":"SN","disabled":true},
                               {"title":"品牌","field":"Brand","disabled":true},
                               {"title":"规格型号","field":"Model","disabled":true}],
                              [{"title":"供应商","field":"Supplier","disabled":true},
                               {"title":"供应商电话","field":"SupplierPhone","disabled":true,"type":"phone"},
                               {"title":"保养计划","field":"ConPlan"},
                               {"title":"保养类型","field":"ConType"}],
                              [{"title":"开始时间","field":"StartTime","type":"date"},
                               {"title":"结束时间","field":"EndTime","type":"date"}],
                              [{"title":"供应商地址","field":"SupplierAddress","disabled":true,"colSize":12,"type":"textarea"}],
                              [{"title":"保养内容","field":"Remarks","colSize":12,"type":"textarea"}],
                              [{"title":"保养文件","field":"FilesUrl","type":"file"}]]);
            const searchFormFields = ref({"DeviceId":"","SN":"","Model":"","Supplier":""});
            const searchFormOptions = ref([[{"dataKey":"设备列表","data":[],"title":"设备名称","field":"DeviceId","type":"like"},{"title":"序列号","field":"SN","type":"like"}],[{"title":"规格型号","field":"Model","type":"like"},{"title":"供应商","field":"Supplier","type":"like"}]]);
            const columns = ref([{field:'Id',title:'Id',type:'int',sort:true,width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'DeviceId',title:'设备名称',type:'string',bind:{ key:'设备列表',data:[]},width:120,align:'left',sort:true},
                       {field:'SN',title:'序列号',type:'string',width:120,readonly:true,align:'left'},
                       {field:'Brand',title:'品牌',type:'string',width:120,readonly:true,align:'left'},
                       {field:'Model',title:'规格型号',type:'string',width:120,readonly:true,align:'left'},
                       {field:'Supplier',title:'供应商',type:'string',width:120,readonly:true,align:'left'},
                       {field:'SupplierAddress',title:'供应商地址',type:'string',width:220,readonly:true,align:'left'},
                       {field:'SupplierPhone',title:'供应商电话',type:'string',width:110,readonly:true,align:'left'},
                       {field:'ConPlan',title:'保养计划',type:'string',width:220,align:'left'},
                       {field:'ConType',title:'保养类型',type:'string',width:180,align:'left'},
                       {field:'StartTime',title:'开始时间',type:'date',width:150,align:'left',sort:true},
                       {field:'EndTime',title:'结束时间',type:'date',width:150,align:'left',sort:true},
                       {field:'Remarks',title:'保养内容',type:'string',width:220,align:'left'},
                       {field:'ReserveOne',title:'ReserveOne',type:'string',width:220,hidden:true,align:'left'},
                       {field:'ReserveTwo',title:'ReserveTwo',type:'string',width:220,hidden:true,align:'left'},
                       {field:'ReserveThree',title:'ReserveThree',type:'string',width:220,hidden:true,align:'left'},
                       {field:'ReserveFour',title:'ReserveFour',type:'string',width:220,hidden:true,align:'left'},
                       {field:'ReserveFive',title:'ReserveFive',type:'string',width:220,hidden:true,align:'left'},
                       {field:'UpdateUser',title:'更新人',type:'string',width:110,hidden:true,align:'left'},
                       {field:'CreateUser',title:'创建人',type:'string',width:110,hidden:true,align:'left'},
                       {field:'UpdateTime',title:'更新时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'CreateTime',title:'创建时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'FilesUrl',title:'保养文件',type:'file',width:220,align:'left'}]);
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
