<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/product/MES_WorkpieceInfo.js此处编写
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
    import extend from "@/extension/system/product/MES_WorkpieceInfo.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'WIID',
                footer: "Foots",
                cnName: '生产工单主表',
                name: 'product/MES_WorkpieceInfo',
                url: "/MES_WorkpieceInfo/",
                sortName: "WIID"
            });
            const editFormFields = ref({"OrderId":"","WorkpieceNumber":"","WorkpieceName":"","ProcessNumber":"","WorkpieceMaterial":"","BlankSize":"","SeriesProcess":"","MachineGroup":"","PalletType":"","UpdateDate":"","ProgrammingPerson":"","ProgramTime":"","DrawingLocation":"","FixtureInstruction":"","SingleFixtureQuantity":"","XYZeroMode":"","ZZeroMode":"","XOffsetValueX2":"","YOffsetValueY2":"","MachiningCoordinateSystem":"","MachiningProgram":"","WorkpieceZeroToPalletPlaneHeightZ4":"","ProbeProgram":"","FixtureAndMachiningZeroDiagram":"","FilesUrl":""});
            const editFormOptions = ref([[{"dataKey":"订单内容","data":[],"title":"订单","field":"OrderId","type":"remoteSearch"},
                               {"title":"工件编号","field":"WorkpieceNumber"},
                               {"title":"工件名称","field":"WorkpieceName"},
                               {"title":"工序编号","field":"ProcessNumber"}],
                              [{"title":"工件材质","field":"WorkpieceMaterial"},
                               {"title":"毛坯尺寸","field":"BlankSize"},
                               {"title":"串联工序","field":"SeriesProcess"},
                               {"title":"机床组别","field":"MachineGroup"}],
                              [{"title":"托盘类型","field":"PalletType"},
                               {"title":"更新日期","field":"UpdateDate","type":"datetime"},
                               {"title":"编程人员","field":"ProgrammingPerson"},
                               {"title":"程式时间","field":"ProgramTime","type":"decimal"}],
                              [{"title":"图档位置","field":"DrawingLocation"},
                               {"title":"装夹说明","field":"FixtureInstruction"},
                               {"title":"单夹数量","field":"SingleFixtureQuantity","type":"number"},
                               {"title":"XY零点方式","field":"XYZeroMode"}],
                              [{"title":"Z零点方式","field":"ZZeroMode"},
                               {"title":"X偏置值","field":"XOffsetValueX2","type":"decimal"},
                               {"title":"Y偏置值","field":"YOffsetValueY2","type":"decimal"},
                               {"title":"加工坐标系","field":"MachiningCoordinateSystem"}],
                              [{"title":"零点托盘高","field":"WorkpieceZeroToPalletPlaneHeightZ4","type":"decimal"},
                               {"title":"加工程序","field":"MachiningProgram"},
                               {"title":"探头程序","field":"ProbeProgram"}],
                              [{"title":"装夹加工示图","field":"FixtureAndMachiningZeroDiagram","type":"file"},
                               {"title":"工单表格","field":"FilesUrl","type":"file"}]]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'WIID',title:'主键，自增',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'OrderId',title:'订单',type:'int',bind:{ key:'订单内容',data:[]},width:80,align:'left',sort:true},
                       {field:'WorkpieceNumber',title:'工件编号',type:'string',width:160,align:'left'},
                       {field:'WorkpieceName',title:'工件名称',type:'string',width:220,align:'left'},
                       {field:'ProcessNumber',title:'工序编号',type:'string',width:160,align:'left'},
                       {field:'WorkpieceMaterial',title:'工件材质',type:'string',width:160,align:'left'},
                       {field:'BlankSize',title:'毛坯尺寸',type:'string',width:160,align:'left'},
                       {field:'SeriesProcess',title:'串联工序',type:'string',width:160,align:'left'},
                       {field:'MachineGroup',title:'机床组别',type:'string',width:160,align:'left'},
                       {field:'PalletType',title:'托盘类型',type:'string',width:160,align:'left'},
                       {field:'UpdateDate',title:'更新日期',type:'datetime',width:150,align:'left',sort:true},
                       {field:'ProgrammingPerson',title:'编程人员',type:'string',width:160,align:'left'},
                       {field:'ProgramTime',title:'程式时间',type:'string',width:160,align:'left'},
                       {field:'DrawingLocation',title:'图档位置',type:'string',width:220,align:'left'},
                       {field:'MachiningProgram',title:'加工程序',type:'string',width:160,align:'left'},
                       {field:'FixtureInstruction',title:'装夹说明',type:'string',width:180,align:'left'},
                       {field:'SingleFixtureQuantity',title:'单夹数量',type:'int',width:160,align:'left'},
                       {field:'XYZeroMode',title:'XY零点方式',type:'string',width:160,align:'left'},
                       {field:'ZZeroMode',title:'Z零点方式',type:'string',width:160,align:'left'},
                       {field:'XOffsetValueX2',title:'X偏置值',type:'decimal',width:160,align:'left'},
                       {field:'YOffsetValueY2',title:'Y偏置值',type:'decimal',width:160,align:'left'},
                       {field:'MachiningCoordinateSystem',title:'加工坐标系',type:'string',width:160,align:'left'},
                       {field:'WorkpieceZeroToPalletPlaneHeightZ4',title:'零点托盘高',type:'decimal',width:160,align:'left'},
                       {field:'ProbeProgram',title:'探头程序',type:'string',width:180,align:'left'},
                       {field:'CreateTime',title:'创建时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'UpdateTime',title:'修改时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'CreateUser',title:'创建人',type:'string',width:110,hidden:true,align:'left'},
                       {field:'UpdateUser',title:'修改人',type:'string',width:110,hidden:true,align:'left'},
                       {field:'FixtureAndMachiningZeroDiagram',title:'装夹加工示图',type:'file',width:220,align:'left'},
                       {field:'FilesUrl',title:'工单表格',type:'file',width:220,align:'left'}]);
            const detail = ref({
                cnName: "生产工单明细",
                table: "MES_WorkpieceInfoDetail",
                columns: [{field:'Id',title:'主键，自增',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'ToolNumber',title:'刀号',type:'string',width:110,edit:{type:''},align:'left',sort:true},
                       {field:'ToolTypeNumber',title:'刀型编号',type:'string',width:110,edit:{type:''},align:'left'},
                       {field:'ToolDiameter',title:'刀具直径',type:'decimal',width:110,edit:{type:''},align:'left'},
                       {field:'ToolInstallationLength',title:'装刀长度',type:'decimal',width:110,edit:{type:''},align:'left'},
                       {field:'RotationalSpeed',title:'转速',type:'int',width:110,edit:{type:''},align:'left'},
                       {field:'FeedRate',title:'进给',type:'decimal',width:110,edit:{type:''},align:'left'},
                       {field:'Allowance',title:'余量',type:'decimal',width:110,edit:{type:''},align:'left'},
                       {field:'ToolCompensationNumber',title:'刀补号',type:'string',width:110,edit:{type:''},align:'left'},
                       {field:'ProcessingTime',title:'时间',type:'decimal',width:110,edit:{type:''},align:'left'},
                       {field:'ZDepth',title:'Z深',type:'decimal',width:110,edit:{type:''},align:'left'},
                       {field:'Remarks',title:'备注',type:'string',width:180,edit:{type:'textarea'},align:'left'},
                       {field:'CreateTime',title:'创建时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'UpdateTime',title:'修改时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'CreateUser',title:'创建人',type:'string',width:110,hidden:true,align:'left'},
                       {field:'UpdateUser',title:'修改人',type:'string',width:110,hidden:true,align:'left'},
                       {field:'WIID',title:'主表 ID',type:'int',width:110,hidden:true,align:'left'}],
                sortName: "Id",
                key: "Id"
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
