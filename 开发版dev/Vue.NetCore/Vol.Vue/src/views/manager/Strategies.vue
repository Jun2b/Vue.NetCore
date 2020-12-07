<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/manager/Strategies.js此处编写
 -->
<template>
    <div>
        <view-grid :columns="columns"
                   :detail="detail"
                   :editFormFields="editFormFields"
                   :editFormFileds="editFormFields"
                   :editFormOptions="editFormOptions"
                   :searchFormFields="searchFormFields"
                   :searchFormFileds="searchFormFields"
                   :searchFormOptions="searchFormOptions"
                   :table="table"
                   :extend="extend">
        </view-grid>
    </div>
</template>

<script>
    import extend from "@/extension/manager/Strategies.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Strategy_Id',
                    footer: "Foots",
                    cnName: '提货策略',
                    name: 'Strategies',
                    url: "/Strategies/",
                    sortName: "Strategy_Id"
                },
                extend: extend,
                editFormFields: {"Strategy_Name":"","Enable":""},
                editFormOptions: [[{"title":"策略名称","field":"Strategy_Name"}],
                              [{"dataKey":"enable","data":[],"title":"是否启用","field":"Enable","type":"switch"}]],
                searchFormFields: {},
                searchFormOptions: [],
                columns: [{field:'Strategy_Name',title:'策略名称',type:'string',link:true,width:220,align:'left',sortable:true},
                       {field:'Enable',title:'是否启用',type:'sbyte',bind:{ key:'enable',data:[]},width:90,align:'left'},
                       {field:'Strategy_Id',title:'策略ID',type:'int',width:90,hidden:true,require:true,align:'left'},
                       {field:'CreateID',title:'提货创建人ID',type:'int',width:80,hidden:true,require:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'创建日期',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'ModifyID',title:'修改人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'修改日期',type:'datetime',width:90,align:'left',sortable:true}],
                detail: {
                    cnName:"提货限制",
                    columns: [{field:'Strategy_Id',title:'策略ID',type:'int',width:90,hidden:true,readonly:true,edit:{type:''},require:true,align:'left'},
                       {field:'OrderDate',title:'提货日期',type:'datetime',width:90,edit:{type:'date'},align:'left',sortable:true},
                       {field:'MaxQty',title:'限制数量',type:'int',link:true,width:90,edit:{type:''},align:'left'},
                       {field:'Message',title:'超限提示',type:'string',width:220,edit:{type:'text'},align:'left'},
                       {field:'Expiredset_Id',title:'限制ID',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'}],
                    sortName: "Expiredset_Id",
                    key:"Expiredset_Id"
                }
            };
        }
    };
    export default vueParam;
</script>
