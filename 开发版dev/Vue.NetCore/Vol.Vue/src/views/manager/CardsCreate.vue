<template>
  <div class="single-form">
    <Divider>系统生成卡号</Divider>
    <VolForm ref="myform" :loadKey="loadKey" :formFileds="formFileds" :formRules="formRules"></VolForm>
    <Button type="success" style="margin-bottom:20px;" long @click="getForm">提交生成</Button>
    <Button type="error" long @click="reset">重置</Button>
  </div>
</template>
<script>
import VolForm from "@/components/basic/VolForm.vue";
let $vue;
export default {
  components: { VolForm },
  created() {
    $vue = this;
  },
  methods: {
    getForm() {
      if (!this.$refs.myform.validate()) {
        return;
      }
      //this.$message.error(JSON.stringify(this.formFileds));
      this.http.post("/api/Cards/generateCards",this.formFileds,'正在生成卡券').then(result=>{
        this.$message.error(result);
      });
    },
    reset() {
      //重置表单，重置时可指定重置的值，如果没有指定重置的值，默认全部清空
      let data = {};
      this.$refs.myform.reset(data);
      this.$message.error("表单已重置");
    }
  },
  data() {
    return {
      loadKey: true,
      formFileds: {
        CateGory_Id:"",
        Card_Name:"",
        Price:null,
        Goods_Id:"",
        Expiry_Time:"",        
        Remark:"",
        Customer_Id:"",
        Sku_Id:"",
        Strategy_Id:"",
        Qty:null
      },
      formRules: [
        [
          {
            dataKey: "category", //后台下拉框对应的数据字典编号
            data: [], //loadKey设置为true,会根据dataKey从后台的下拉框数据源中自动加载数据
            title: "卡券类别",
            required: true, //设置为必选项
            field: "CateGory_Id",
            colSize: 12,
            placeholder: "选择卡券类别",
            type: "select"
          }
        ],
        [
          {
            title: "卡券名称",
            required: true,
            placeholder: "输入卡券名称", 
            field: "Card_Name",
            colSize: 12
          }
        ],
        [
          {
            type: "decimal",
            title: "卡券价格",
            required: true,
            placeholder: "价格", //显示自定义的信息
            field: "Price",
            colSize: 12
          }
        ],
        [
          {
            dataKey: "goods", //后台下拉框对应的数据字典编号
            data: [], //loadKey设置为true,会根据dataKey从后台的下拉框数据源中自动加载数据
            //data是须的参数，可以默认一个[]
            title: "商品名称",
            required: false, 
            field: "Goods_Id",
            colSize: 12,
            placeholder: "选择关联商品",
            type: "select"
          }
        ],
        [
          {
            title: "过期日期",
            required: true,
            field: "Expiry_Time",
            colSize: 12,
            type: "date"
          }
        ],
        [
          {
            title: "卡券备注",
            required: false,
            placeholder: "卡券备注", 
            field: "Remark",
            colSize: 12
          }
        ],
        [
          {
            dataKey: "customers", //后台下拉框对应的数据字典编号
            data: [], //loadKey设置为true,会根据dataKey从后台的下拉框数据源中自动加载数据
            //data是须的参数，可以默认一个[]
            title: "销售客户",
            required: false, 
            field: "Customer_Id",
            colSize: 12,
            placeholder: "销售客户",
            type: "select"
          }
        ],
        [
          {
            dataKey: "shortsku", //后台下拉框对应的数据字典编号
            data: [], //loadKey设置为true,会根据dataKey从后台的下拉框数据源中自动加载数据
            //data是须的参数，可以默认一个[]
            title: "发货规格",
            required: false, //设置为必选项
            field: "Sku_Id",
            colSize: 12,
            placeholder: "选择发货规格",
            type: "select"
          }
        ],
        [
          {
            dataKey: "strategies", //后台下拉框对应的数据字典编号
            data: [], //loadKey设置为true,会根据dataKey从后台的下拉框数据源中自动加载数据
            //data是须的参数，可以默认一个[]
            title: "提货策略",
            required: false, //设置为必选项
            field: "Strategy_Id",
            colSize: 12,
            placeholder: "选择提货策略",
            type: "select"
          }
        ],
        [
          {
            title: "生成数量",
            required: true,
            field: "Qty",
            colSize: 12,
            type: "number",
            min:100,
            max:10000
          }
        ]

      ]
    };
  }
};
</script>
<style scoped>
.single-form {
    position: relative;
    max-width: 600px;
    padding: 30px 45px;
    left: 0;
    box-shadow: #d6d6d6 0px 4px 21px;
    margin: auto;
}
</style>