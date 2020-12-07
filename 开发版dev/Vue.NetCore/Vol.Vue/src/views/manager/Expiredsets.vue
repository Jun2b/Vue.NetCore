<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/manager/Expiredsets.js此处编写
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
    import extend from "@/extension/manager/Expiredsets.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Expiredset_Id',
                    footer: "Foots",
                    cnName: '提货限制',
                    name: 'Expiredsets',
                    url: "/Expiredsets/",
                    sortName: "Expiredset_Id"
                },
                extend: extend,
                editFormFields: {"Strategy_Id":"","OrderDate":"","MaxQty":"","Message":""},
                editFormOptions: [[{"title":"策略ID","required":true,"field":"Strategy_Id","disabled":true,"type":"number"}],
                              [{"title":"提货日期","field":"OrderDate","type":"date"}],
                              [{"title":"限制数量","field":"MaxQty","type":"number"}],
                              [{"title":"超限提示","field":"Message","type":"text"}]],
                searchFormFields: {"OrderDate":""},
                searchFormOptions: [[{"title":"提货日期","field":"OrderDate","type":"date"}]],
                columns: [{field:'Strategy_Id',title:'策略ID',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'OrderDate',title:'提货日期',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'MaxQty',title:'限制数量',type:'int',link:true,width:90,align:'left'},
                       {field:'Message',title:'超限提示',type:'string',width:220,align:'left'},
                       {field:'Expiredset_Id',title:'限制ID',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'}],
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
