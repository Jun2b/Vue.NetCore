/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "卡券管理",TableName = "Cards")]
    public class Cards:BaseEntity
    {
        /// <summary>
       ///礼券分类
       /// </summary>
       [Display(Name ="礼券分类")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int CateGory_Id { get; set; }

       /// <summary>
       ///礼券名称
       /// </summary>
       [Display(Name ="礼券名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string Card_Name { get; set; }

       /// <summary>
       ///卡号
       /// </summary>
       [Display(Name ="卡号")]
       [MaxLength(32)]
       [Column(TypeName="nvarchar(32)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Card_No { get; set; }

       /// <summary>
       ///密码
       /// </summary>
       [Display(Name ="密码")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string Card_Pwd { get; set; }

       /// <summary>
       ///激活状态
       /// </summary>
       [Display(Name ="激活状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Card_Status { get; set; }

       /// <summary>
       ///提货状态
       /// </summary>
       [Display(Name ="提货状态")]
       [Column(TypeName="sbyte")]
       [Editable(true)]
       public sbyte? Card_Ship_Status { get; set; }

       /// <summary>
       ///过期日期
       /// </summary>
       [Display(Name ="过期日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? Expiry_Time { get; set; }

       /// <summary>
       ///商品名称
       /// </summary>
       [Display(Name ="商品名称")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Goods_Id { get; set; }

       /// <summary>
       ///礼券备注
       /// </summary>
       [Display(Name ="礼券备注")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///价格
       /// </summary>
       [Display(Name ="价格")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? Price { get; set; }

       /// <summary>
       ///销售客户
       /// </summary>
       [Display(Name ="销售客户")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Customer_Id { get; set; }

       /// <summary>
       ///发货规格
       /// </summary>
       [Display(Name ="发货规格")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Sku_Id { get; set; }

       /// <summary>
       ///提货限制策略
       /// </summary>
       [Display(Name ="提货限制策略")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Strategy_Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Card_Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Card_Id { get; set; }

       /// <summary>
       ///创建人ID
       /// </summary>
       [Display(Name ="创建人ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int CreateID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改人ID
       /// </summary>
       [Display(Name ="修改人ID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string Modifier { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       
    }
}