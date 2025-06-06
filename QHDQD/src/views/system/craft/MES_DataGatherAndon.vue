<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/craft/MES_DataGatherAndon.js此处编写
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
    import extend from "@/extension/system/craft/MES_DataGatherAndon.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'Id',
                footer: "Foots",
                cnName: '安灯信息',
                name: 'craft/MES_DataGatherAndon',
                url: "/MES_DataGatherAndon/",
                sortName: "Id"
            });
            const editFormFields = ref({"AndonAddress":"","PLCAddress":""});
            const editFormOptions = ref([[{"title":"安灯位置","field":"AndonAddress"}],
                              [{"title":"通讯地址","field":"PLCAddress"}]]);
            const searchFormFields = ref({"AndonAddress":"","Status":"","PLCAddress":""});
            const searchFormOptions = ref([[{"title":"安灯位置","field":"AndonAddress"},{"dataKey":"enable","data":[],"title":"安灯状态","field":"Status","type":"select"},{"title":"通讯地址","field":"PLCAddress"}]]);
            const columns = ref([{field:'Id',title:'主键',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'AndonAddress',title:'安灯位置',type:'string',width:120,align:'left',sort:true},
                       {field:'Status',title:'安灯状态',type:'string',bind:{ key:'enable',data:[]},width:110,align:'left'},
                       {field:'PLCAddress',title:'通讯地址',type:'string',width:120,align:'left'},
                       {field:'CreateUser',title:'创建人',type:'string',width:120,align:'left'},
                       {field:'CreateTime',title:'创建时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'UpdateUser',title:'更新人',type:'string',width:120,align:'left'},
                       {field:'UpdateTime',title:'更新时间',type:'datetime',width:150,align:'left',sort:true}]);
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
