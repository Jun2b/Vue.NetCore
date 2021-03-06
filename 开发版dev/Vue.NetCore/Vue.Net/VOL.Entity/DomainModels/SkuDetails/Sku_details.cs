using Newtonsoft.Json;
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
    [Entity(TableCnName = "规格明细",TableName = "Sku_details")]
    public class Sku_details:BaseEntity
    {
        /// <summary>
       ///规格
       /// </summary>
       [Display(Name ="规格")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Sku_Id { get; set; }

       /// <summary>
       ///部件
       /// </summary>
       [Display(Name ="部件")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Part_Id { get; set; }

       /// <summary>
       ///部件数量
       /// </summary>
       [Display(Name ="部件数量")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Part_Qty { get; set; }

       /// <summary>
       ///是否启用
       /// </summary>
       [Display(Name ="是否启用")]
       [Column(TypeName="sbyte")]
       [Editable(true)]
       public sbyte? Enable { get; set; }

       /// <summary>
       ///规格明细ID
       /// </summary>
       [Key]
       [Display(Name ="规格明细ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Sku_Detail_Id { get; set; }

       /// <summary>
       ///明细创建人ID
       /// </summary>
       [Display(Name ="明细创建人ID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(255)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(255)")]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [JsonIgnore]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改人ID
       /// </summary>
       [Display(Name ="修改人ID")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(255)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(255)")]
       public string Modifier { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [JsonIgnore]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       
    }
}
