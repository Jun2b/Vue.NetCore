<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/manager/Skus.js此处编写
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
    import extend from "@/extension/manager/Skus.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Sku_Id',
                    footer: "Foots",
                    cnName: '属性规格',
                    name: 'Skus',
                    url: "/Skus/",
                    sortName: "Sku_Id"
                },
                extend: extend,
                editFormFields: {"Sku_Name":"","Enable":""},
                editFormOptions: [[{"title":"规格名称","field":"Sku_Name"}],
                              [{"dataKey":"enable","data":[],"title":"是否启用","field":"Enable","type":"switch"}]],
                searchFormFields: {},
                searchFormOptions: [],
                columns: [{field:'Sku_Name',title:'规格名称',type:'string',link:true,width:220,align:'left',sortable:true},
                       {field:'Enable',title:'是否启用',type:'sbyte',bind:{ key:'enable',data:[]},width:90,align:'left'},
                       {field:'Sku_Id',title:'规格属性ID',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'CreateID',title:'创建人ID',type:'int',width:80,hidden:true,require:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'ModifyID',title:'修改人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'修改时间',type:'datetime',width:90,align:'left',sortable:true}],
                detail: {
                    cnName:"规格明细",
                    columns: [{field:'Sku_Id',title:'规格',type:'int',width:90,hidden:true,readonly:true,edit:{type:''},require:true,align:'left'},
                       {field:'Part_Id',title:'部件',type:'int',bind:{ key:'parts',data:[]},width:90,edit:{type:'select'},align:'left',sortable:true},
                       {field:'Part_Qty',title:'部件数量',type:'int',width:90,edit:{type:''},align:'left'},
                       {field:'Enable',title:'是否启用',type:'sbyte',bind:{ key:'enable',data:[]},width:90,edit:{type:'switch'},align:'left'},
                       {field:'Sku_Detail_Id',title:'规格明细ID',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'CreateID',title:'明细创建人ID',type:'int',width:80,hidden:true,readonly:true,align:'left'}],
                    sortName: "Sku_Detail_Id",
                    key:"Sku_Detail_Id"
                }
            };
        }
    };
    export default vueParam;
</script>
