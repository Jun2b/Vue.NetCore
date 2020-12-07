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
    [Entity(TableCnName = "属性规格",TableName = "Skus",DetailTable =  new Type[] { typeof(Sku_details)},DetailTableCnName = "规格明细")]
    public class Skus:BaseEntity
    {
        /// <summary>
       ///规格名称
       /// </summary>
       [Display(Name ="规格名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string Sku_Name { get; set; }

       /// <summary>
       ///是否启用
       /// </summary>
       [Display(Name ="是否启用")]
       [Column(TypeName="sbyte")]
       [Editable(true)]
       public sbyte? Enable { get; set; }

       /// <summary>
       ///规格属性ID
       /// </summary>
       [Key]
       [Display(Name ="规格属性ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Sku_Id { get; set; }

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

       [Display(Name ="规格明细")]
       [ForeignKey("Sku_Id")]
       public List<Sku_details> Sku_details { get; set; }

    }
}