<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/manager/Goods.js此处编写
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
    import extend from "@/extension/manager/Goods.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Goods_Id',
                    footer: "Foots",
                    cnName: '商品管理',
                    name: 'Goods',
                    url: "/Goods/",
                    sortName: "Goods_Id"
                },
                extend: extend,
                editFormFields: {"Goods_Name":"","CateGory_Id":"","Enable":""},
                editFormOptions: [[{"title":"商品名称","field":"Goods_Name"}],
                              [{"dataKey":"category","data":[],"title":"商品分类","field":"CateGory_Id","type":"select"}],
                              [{"dataKey":"enable","data":[],"title":"是否启用","field":"Enable","type":"switch"}]],
                searchFormFields: {"CateGory_Id":""},
                searchFormOptions: [[{"dataKey":"category","data":[],"title":"商品分类","field":"CateGory_Id","type":"select"}]],
                columns: [{field:'Goods_Name',title:'商品名称',type:'string',link:true,width:220,align:'left',sortable:true},
                       {field:'CateGory_Id',title:'商品分类',type:'int',bind:{ key:'category',data:[]},width:120,align:'left'},
                       {field:'Enable',title:'是否启用',type:'sbyte',bind:{ key:'enable',data:[]},width:120,align:'left'},
                       {field:'Goods_Id',title:'商品ID',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'CreateID',title:'创建人ID',type:'int',width:80,hidden:true,require:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'创建日期',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'ModifyID',title:'修改人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'修改日期',type:'datetime',width:90,align:'left',sortable:true}],
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
