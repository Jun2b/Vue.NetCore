<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/manager/Sku_details.js此处编写
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
    import extend from "@/extension/manager/Sku_details.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Sku_Detail_Id',
                    footer: "Foots",
                    cnName: '规格明细',
                    name: 'Sku_details',
                    url: "/Sku_details/",
                    sortName: "Sku_Detail_Id"
                },
                extend: extend,
                editFormFields: {"Sku_Id":"","Part_Id":"","Part_Qty":"","Enable":""},
                editFormOptions: [[{"title":"规格","required":true,"field":"Sku_Id","disabled":true,"type":"number"}],
                              [{"dataKey":"parts","data":[],"title":"部件","field":"Part_Id","type":"select"}],
                              [{"title":"部件数量","field":"Part_Qty","type":"number"}],
                              [{"dataKey":"enable","data":[],"title":"是否启用","field":"Enable","type":"switch"}]],
                searchFormFields: {},
                searchFormOptions: [],
                columns: [{field:'Sku_Id',title:'规格',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Part_Id',title:'部件',type:'int',bind:{ key:'parts',data:[]},width:90,align:'left',sortable:true},
                       {field:'Part_Qty',title:'部件数量',type:'int',width:90,align:'left'},
                       {field:'Enable',title:'是否启用',type:'sbyte',bind:{ key:'enable',data:[]},width:90,align:'left'},
                       {field:'Sku_Detail_Id',title:'规格明细ID',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'CreateID',title:'明细创建人ID',type:'int',width:80,hidden:true,readonly:true,align:'left'}],
                detail: {
                    cnName:"#detailCnName",
                    columns: [],
                    sortName: "",
                    key:""
                }
            };
        }
    };
    export default vueParam;
</script>
