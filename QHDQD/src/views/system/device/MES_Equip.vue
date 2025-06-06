<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/device/MES_Equip.js此处编写
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
    import extend from "@/extension/system/device/MES_Equip.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'Id',
                footer: "Foots",
                cnName: '设备信息',
                name: 'device/MES_Equip',
                url: "/MES_Equip/",
                sortName: "Id"
            });
            const editFormFields = ref({"Name":"","SN":"","Brand":"","Model":"","QCEndDate":"","Supplier":"","SupplierPhone":"","InDate":"","IsPivotal":"","IsVulnerable":"","Ip":"","MAC":"","SupplierAddress":""});
            const editFormOptions = ref([[{"title":"设备名称","required":true,"field":"Name"},
                               {"title":"序列号","required":true,"field":"SN"},
                               {"title":"品牌","required":true,"field":"Brand"},
                               {"title":"规格型号","required":true,"field":"Model"}],
                              [{"title":"供应商","required":true,"field":"Supplier"},
                               {"title":"入厂时间","required":true,"field":"InDate","type":"date"},
                               {"title":"质保到期日","field":"QCEndDate","type":"date"},
                               {"title":"供应商电话","field":"SupplierPhone","type":"phone"}],
                              [{"dataKey":"enable","data":[],"title":"关键设备","field":"IsPivotal","type":"select"},
                               {"dataKey":"enable","data":[],"title":"易损设备","field":"IsVulnerable","type":"select"},
                               {"title":"IP地址","field":"Ip"},
                               {"title":"MAC","field":"MAC"}],
                              [{"title":"供应商地址","required":true,"field":"SupplierAddress","colSize":12,"type":"textarea"}]]);
            const searchFormFields = ref({"Name":"","SN":"","Brand":"","Model":"","Supplier":"","SupplierPhone":""});
            const searchFormOptions = ref([[{"title":"设备名称","field":"Name","type":"like"},{"title":"序列号","field":"SN","type":"like"},{"title":"品牌","field":"Brand","type":"like"}],[{"title":"规格型号","field":"Model","type":"like"},{"title":"供应商","field":"Supplier","type":"like"},{"title":"供应商电话","field":"SupplierPhone","type":"like"}]]);
            const columns = ref([{field:'Id',title:'主键',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Name',title:'设备名称',type:'string',width:220,require:true,align:'left',sort:true},
                       {field:'SN',title:'序列号',type:'string',width:120,require:true,align:'left'},
                       {field:'Brand',title:'品牌',type:'string',width:120,require:true,align:'left'},
                       {field:'Model',title:'规格型号',type:'string',width:160,require:true,align:'left'},
                       {field:'QCEndDate',title:'质保到期日',type:'date',width:150,align:'left',sort:true},
                       {field:'Supplier',title:'供应商',type:'string',width:120,require:true,align:'left'},
                       {field:'SupplierAddress',title:'供应商地址',type:'string',width:220,require:true,align:'left'},
                       {field:'SupplierPhone',title:'供应商电话',type:'string',width:150,align:'left'},
                       {field:'InDate',title:'入厂时间',type:'date',width:150,require:true,align:'left',sort:true},
                       {field:'IsPivotal',title:'关键设备',type:'string',bind:{ key:'enable',data:[]},width:110,align:'left'},
                       {field:'IsVulnerable',title:'易损设备',type:'string',bind:{ key:'enable',data:[]},width:110,align:'left'},
                       {field:'Ip',title:'IP地址',type:'string',width:110,align:'left'},
                       {field:'MAC',title:'MAC',type:'string',width:150,align:'left'}]);
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
