let viewgird = [
   {
        path: '/Sys_Log',
        name: 'sys_Log',
        component: () => import('@/views/system/Sys_Log.vue')
    }
    ,{
        path: '/Sys_User',
        name: 'Sys_User',
        component: () => import('@/views/system/Sys_User.vue')
    }    ,{
        path: '/Sys_Dictionary',
        name: 'Sys_Dictionary',
        component: () => import('@/views/system/Sys_Dictionary.vue')
    }    ,{
        path: '/Sys_Role',
        name: 'Sys_Role',
        component: () => import('@/views/system/Sys_Role.vue')
    }
    ,{
        path: '/Sys_DictionaryList',
        name: 'Sys_DictionaryList',
        component: () => import('@/views/system/Sys_DictionaryList.vue')
    }    ,{
        path: '/Goods',
        name: 'Goods',
        component: () => import('@/views/manager/Goods.vue')
    }    ,{
        path: '/Skus',
        name: 'Skus',
        component: () => import('@/views/manager/Skus.vue')
    }    ,{
        path: '/Strategies',
        name: 'Strategies',
        component: () => import('@/views/manager/Strategies.vue')
    }    ,{
        path: '/Expiredsets',
        name: 'Expiredsets',
        component: () => import('@/views/manager/Expiredsets.vue')
    }    ,{
        path: '/Customers',
        name: 'Customers',
        component: () => import('@/views/manager/Customers.vue')
    }    ,{
        path: '/Parts',
        name: 'Parts',
        component: () => import('@/views/manager/Parts.vue')
    }    ,{
        path: '/Sku_details',
        name: 'Sku_details',
        component: () => import('@/views/manager/Sku_details.vue')
    }    ,{
        path: '/Shops',
        name: 'Shops',
        component: () => import('@/views/manager/Shops.vue')
    }    ,{
        path: '/Cards',
        name: 'Cards',
        component: () => import('@/views/manager/Cards.vue')
    }]
export default viewgird
