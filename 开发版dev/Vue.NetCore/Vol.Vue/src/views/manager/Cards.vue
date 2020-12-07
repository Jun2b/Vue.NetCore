<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/manager/Cards.js此处编写
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
    import extend from "@/extension/manager/Cards.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Card_Id',
                    footer: "Foots",
                    cnName: '卡券管理',
                    name: 'Cards',
                    url: "/Cards/",
                    sortName: "Card_Id"
                },
                extend: extend,
                editFormFields: {"CateGory_Id":"","Card_Name":"","Card_No":"","Card_Pwd":"","Card_Status":"","Card_Ship_Status":"","Expiry_Time":"","Goods_Id":"","Remark":"","Price":"","Customer_Id":"","Sku_Id":"","Strategy_Id":""},
                editFormOptions: [[{"dataKey":"category","data":[],"title":"礼券分类","required":true,"field":"CateGory_Id","type":"select"}],
                              [{"title":"礼券名称","field":"Card_Name"}],
                              [{"title":"卡号","required":true,"field":"Card_No"}],
                              [{"title":"密码","field":"Card_Pwd"}],
                              [{"dataKey":"card_status","data":[],"title":"激活状态","field":"Card_Status","type":"select"}],
                              [{"dataKey":"card_ship_staus","data":[],"title":"提货状态","field":"Card_Ship_Status","type":"select"}],
                              [{"title":"过期日期","field":"Expiry_Time","type":"date"}],
                              [{"dataKey":"goods","data":[],"title":"商品名称","required":true,"field":"Goods_Id","type":"select"}],
                              [{"title":"礼券备注","field":"Remark"}],
                              [{"title":"价格","field":"Price","type":"decimal"}],
                              [{"dataKey":"customers","data":[],"title":"销售客户","field":"Customer_Id","type":"select"}],
                              [{"dataKey":"shortsku","data":[],"title":"发货规格","field":"Sku_Id","type":"select"}],
                              [{"dataKey":"strategies","data":[],"title":"提货限制策略","field":"Strategy_Id","type":"select"}]],
                searchFormFields: {"Card_Status":"","Card_Ship_Status":"","Goods_Id":"","Customer_Id":""},
                searchFormOptions: [[{"dataKey":"goods","data":[],"title":"商品名称","field":"Goods_Id","type":"number"}],[{"dataKey":"card_status","data":[],"title":"激活状态","field":"Card_Status","type":"number"}],[{"dataKey":"card_ship_staus","data":[],"title":"提货状态","field":"Card_Ship_Status"}],[{"dataKey":"customers","data":[],"title":"销售客户","field":"Customer_Id","type":"select"}]],
                columns: [{field:'CateGory_Id',title:'礼券分类',type:'int',bind:{ key:'category',data:[]},width:90,hidden:true,require:true,align:'left'},
                       {field:'Card_Name',title:'礼券名称',type:'string',width:220,align:'left',sortable:true},
                       {field:'Card_No',title:'卡号',type:'string',link:true,width:90,require:true,align:'left'},
                       {field:'Card_Pwd',title:'密码',type:'string',width:220,align:'left'},
                       {field:'Card_Status',title:'激活状态',type:'int',bind:{ key:'card_status',data:[]},width:90,align:'left'},
                       {field:'Card_Ship_Status',title:'提货状态',type:'sbyte',bind:{ key:'card_ship_staus',data:[]},width:90,align:'left'},
                       {field:'Expiry_Time',title:'过期日期',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'Goods_Id',title:'商品名称',type:'int',bind:{ key:'goods',data:[]},width:90,require:true,align:'left'},
                       {field:'Remark',title:'礼券备注',type:'string',width:220,align:'left'},
                       {field:'Price',title:'价格',type:'decimal',width:120,align:'left'},
                       {field:'Customer_Id',title:'销售客户',type:'int',bind:{ key:'customers',data:[]},width:90,align:'left'},
                       {field:'Sku_Id',title:'发货规格',type:'int',bind:{ key:'shortsku',data:[]},width:90,align:'left'},
                       {field:'Strategy_Id',title:'提货限制策略',type:'int',bind:{ key:'strategies',data:[]},width:90,align:'left'},
                       {field:'Card_Id',title:'Card_Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'CreateID',title:'创建人ID',type:'int',width:80,hidden:true,require:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'ModifyID',title:'修改人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'修改时间',type:'datetime',width:90,align:'left',sortable:true}],
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
