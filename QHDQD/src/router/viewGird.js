
let viewgird = [
  {
    path: '/Sys_Log',
    name: 'sys_Log',
    component: () => import('@/views/system/Sys_Log.vue')
  },
  {
    path: '/Sys_User',
    name: 'Sys_User',
    component: () => import('@/views/system/Sys_User.vue')
  },
  {
    path: '/permission',
    name: 'permission',
    component: () => import('@/views/system/Permission.vue')
  },

  {
    path: '/Sys_Dictionary',
    name: 'Sys_Dictionary',
    component: () => import('@/views/system/Sys_Dictionary.vue')
  },
  {
    path: '/Sys_Role',
    name: 'Sys_Role',
    component: () => import('@/views/system/Sys_Role.vue')
  }, {
    path: '/Sys_Role1',
    name: 'Sys_Role1',
    component: () => import('@/views/system/Sys_Role1.vue')
  }
  , {
    path: '/Sys_DictionaryList',
    name: 'Sys_DictionaryList',
    component: () => import('@/views/system/Sys_DictionaryList.vue')
  }, {
    path: '/FormDesignOptions',
    name: 'FormDesignOptions',
    component: () => import('@/views/system/form/FormDesignOptions.vue')
  }, {
    path: '/FormCollectionObject',
    name: 'FormCollectionObject',
    component: () => import('@/views/system/form/FormCollectionObject.vue')
  }, {
    path: '/Sys_WorkFlow',
    name: 'Sys_WorkFlow',
    component: () => import('@/views/system/flow/Sys_WorkFlow.vue')
  }, {
    path: '/Sys_WorkFlowTable',
    name: 'Sys_WorkFlowTable',
    component: () => import('@/views/system/flow/Sys_WorkFlowTable.vue')
  }, {
    path: '/Sys_QuartzOptions',
    name: 'Sys_QuartzOptions',
    component: () => import('@/views/system/quartz/Sys_QuartzOptions.vue')
  }, {
    path: '/Sys_QuartzLog',
    name: 'Sys_QuartzLog',
    component: () => import('@/views/system/quartz/Sys_QuartzLog.vue')
  }, {
    path: '/Sys_Department',
    name: 'Sys_Department',
    component: () => import('@/views/system/system/Sys_Department.vue')
  }    ,{
        path: '/MES_Equip',
        name: 'MES_Equip',
        component: () => import('@/views/system/device/MES_Equip.vue')
    }    ,{
        path: '/MES_Conserve',
        name: 'MES_Conserve',
        component: () => import('@/views/system/device/MES_Conserve.vue')
    }    ,{
        path: '/View_MES_Conserve',
        name: 'View_MES_Conserve',
        component: () => import('@/views/system/device/View_MES_Conserve.vue')
    }    ,{
        path: '/View_MES_Maintenance',
        name: 'View_MES_Maintenance',
        component: () => import('@/views/system/device/View_MES_Maintenance.vue')
    }    ,{
        path: '/Pac_Routing_Op',
        name: 'Pac_Routing_Op',
        component: () => import('@/views/system/product/Pac_Routing_Op.vue')
    }    ,{
        path: '/View_MES_ProductScheduling',
        name: 'View_MES_ProductScheduling',
        component: () => import('@/views/system/product/View_MES_ProductScheduling.vue')
    }    ,{
        path: '/MES_ToolInfo',
        name: 'MES_ToolInfo',
        component: () => import('@/views/system/craft/MES_ToolInfo.vue')
    }    ,{
        path: '/MES_WorkpieceInfo',
        name: 'MES_WorkpieceInfo',
        component: () => import('@/views/system/product/MES_WorkpieceInfo.vue')
    }    ,{
        path: '/MES_WorkpieceInfoDetail',
        name: 'MES_WorkpieceInfoDetail',
        component: () => import('@/views/system/product/MES_WorkpieceInfoDetail.vue')
    }    ,{
        path: '/View_MES_WorkpieceInfo',
        name: 'View_MES_WorkpieceInfo',
        component: () => import('@/views/system/product/View_MES_WorkpieceInfo.vue')
    }    ,{
        path: '/MES_Craft',
        name: 'MES_Craft',
        component: () => import('@/views/system/craft/MES_Craft.vue')
    }    ,{
        path: '/MES_DataGatherAndon',
        name: 'MES_DataGatherAndon',
        component: () => import('@/views/system/craft/MES_DataGatherAndon.vue')
    }    ,{
        path: '/MES_Attachment',
        name: 'MES_Attachment',
        component: () => import('@/views/system/craft/MES_Attachment.vue')
    }    ,{
        path: '/QHD_material',
        name: 'QHD_material',
        component: () => import('@/views/system/warehouse/QHD_material.vue')
    }    ,{
        path: '/WMS_PutStock',
        name: 'WMS_PutStock',
        component: () => import('@/views/system/warehouse/WMS_PutStock.vue')
    }    ,{
        path: '/WMS_Stock',
        name: 'WMS_Stock',
        component: () => import('@/views/system/inventory/WMS_Stock.vue')
    }    ,{
        path: '/WMS_InOutTake',
        name: 'WMS_InOutTake',
        component: () => import('@/views/system/task/WMS_InOutTake.vue')
    }    ,{
        path: '/View_FMS_cnc1daoku',
        name: 'View_FMS_cnc1daoku',
        component: () => import('@/views/system/craft/View_FMS_cnc1daoku.vue')
    }    ,{
        path: '/MES_Report_Work',
        name: 'MES_Report_Work',
        component: () => import('@/views/system/reportwork/MES_Report_Work.vue')
    }]

export default viewgird
