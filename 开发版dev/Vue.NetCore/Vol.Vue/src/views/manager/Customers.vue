<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/manager/Customers.js此处编写
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
    import extend from "@/extension/manager/Customers.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Customer_Id',
                    footer: "Foots",
                    cnName: '客户管理',
                    name: 'Customers',
                    url: "/Customers/",
                    sortName: "Customer_Id"
                },
                extend: extend,
                editFormFields: {"Customer_Name":"","Phone":"","Address":"","Enable":""},
                editFormOptions: [[{"title":"客户名称","field":"Customer_Name"}],
                              [{"title":"电话号码","field":"Phone"}],
                              [{"title":"地址","field":"Address"}],
                              [{"dataKey":"enable","data":[],"title":"是否启用","field":"Enable","type":"switch"}]],
                searchFormFields: {"Customer_Name":"","Phone":""},
                searchFormOptions: [[{"title":"客户名称","field":"Customer_Name","type":"like"},{"title":"电话号码","field":"Phone","type":"like"}]],
                columns: [{field:'Customer_Name',title:'客户名称',type:'string',link:true,width:220,align:'left',sortable:true},
                       {field:'Phone',title:'电话号码',type:'string',width:90,align:'left'},
                       {field:'Address',title:'地址',type:'string',width:220,align:'left'},
                       {field:'Enable',title:'是否启用',type:'sbyte',bind:{ key:'enable',data:[]},width:90,align:'left'},
                       {field:'Customer_Id',title:'客户ID',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
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
