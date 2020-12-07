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
    [Entity(TableCnName = "商品管理",TableName = "Goods")]
    public class Goods:BaseEntity
    {
        /// <summary>
       ///商品名称
       /// </summary>
       [Display(Name ="商品名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string Goods_Name { get; set; }

       /// <summary>
       ///商品分类
       /// </summary>
       [Display(Name ="商品分类")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CateGory_Id { get; set; }

       /// <summary>
       ///是否启用
       /// </summary>
       [Display(Name ="是否启用")]
       [Column(TypeName="sbyte")]
       [Editable(true)]
       public sbyte? Enable { get; set; }

       /// <summary>
       ///商品ID
       /// </summary>
       [Key]
       [Display(Name ="商品ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Goods_Id { get; set; }

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
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
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
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       
    }
}