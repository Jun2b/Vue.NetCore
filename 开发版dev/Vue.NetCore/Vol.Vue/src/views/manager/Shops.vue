<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/manager/Shops.js此处编写
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
    import extend from "@/extension/manager/Shops.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Shops_Id',
                    footer: "Foots",
                    cnName: '商家设置',
                    name: 'Shops',
                    url: "/Shops/",
                    sortName: "Shops_Id"
                },
                extend: extend,
                editFormFields: {"ShopName":"","User_Id":"","Prefix":"","Middle":"","ServePhone":"","SMS_Qty":"","OpenDateStart":"","OpenDateEnd":"","OrderDateStart":"","Message":"","OrderDateEnd":"","Deadline":"","Announcement":"","BannerImg":""},
                editFormOptions: [[{"title":"商家名称","field":"ShopName","type":"text"}],
                              [{"dataKey":"users","data":[],"title":"商家用户名","required":true,"field":"User_Id","type":"select"}],
                              [{"title":"卡号前缀","required":true,"field":"Prefix","type":"number"}],
                              [{"title":"卡号中段","required":true,"field":"Middle","type":"number"}],
                              [{"title":"服务电话","field":"ServePhone","type":"phone"}],
                              [{"title":"短信剩余","field":"SMS_Qty","type":"number"}],
                              [{"title":"开放日期","field":"OpenDateStart","type":"date"}],
                              [{"title":"关闭日期","field":"OpenDateEnd","type":"date"}],
                              [{"title":"预约开始","field":"OrderDateStart","type":"date"}],
                              [{"title":"系统关闭提示信息","field":"Message","type":"text"}],
                              [{"title":"预约结束","field":"OrderDateEnd","type":"date"}],
                              [{"title":"预约时间点","field":"Deadline","type":"number"}],
                              [{"title":"提货公告","field":"Announcement","type":"textarea"}],
                              [{"title":"提货首页图片","field":"BannerImg","type":"img"}]],
                searchFormFields: {"ShopName":""},
                searchFormOptions: [[{"title":"商家名称","field":"ShopName","type":"like"}]],
                columns: [{field:'ShopName',title:'商家名称',type:'string',link:true,width:220,align:'left',sortable:true},
                       {field:'User_Id',title:'商家用户名',type:'int',bind:{ key:'users',data:[]},width:90,require:true,align:'left'},
                       {field:'Prefix',title:'卡号前缀',type:'int',width:90,require:true,align:'left'},
                       {field:'Middle',title:'卡号中段',type:'int',width:90,require:true,align:'left'},
                       {field:'ServePhone',title:'服务电话',type:'string',width:220,align:'left'},
                       {field:'SMS_Qty',title:'短信剩余',type:'int',width:90,align:'left'},
                       {field:'OpenDateStart',title:'开放日期',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'OpenDateEnd',title:'关闭日期',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'Message',title:'系统关闭提示信息',type:'string',width:220,align:'left'},
                       {field:'OrderDateStart',title:'预约开始',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'OrderDateEnd',title:'预约结束',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'Deadline',title:'预约时间点',type:'int',width:90,align:'left'},
                       {field:'Announcement',title:'提货公告',type:'string',width:90,align:'left'},
                       {field:'BannerImg',title:'提货首页图片',type:'img',width:220,align:'left'},
                       {field:'Shops_Id',title:'店铺ID',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
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
