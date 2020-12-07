<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/manager/Parts.js此处编写
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
    import extend from "@/extension/manager/Parts.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Part_Id',
                    footer: "Foots",
                    cnName: '部件管理',
                    name: 'Parts',
                    url: "/Parts/",
                    sortName: "Part_Id"
                },
                extend: extend,
                editFormFields: {"Part_Name":"","Enable":""},
                editFormOptions: [[{"title":"部件名称","field":"Part_Name"}],
                              [{"dataKey":"enable","data":[],"title":"是否启用","field":"Enable","type":"switch"}]],
                searchFormFields: {},
                searchFormOptions: [],
                columns: [{field:'Part_Name',title:'部件名称',type:'string',link:true,width:220,align:'left',sortable:true},
                       {field:'Enable',title:'是否启用',type:'sbyte',bind:{ key:'enable',data:[]},width:90,align:'left'},
                       {field:'Part_Id',title:'部件ID',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
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
