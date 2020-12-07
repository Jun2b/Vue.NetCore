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
    [Entity(TableCnName = "提货策略",TableName = "Strategies",DetailTable =  new Type[] { typeof(Expiredsets)},DetailTableCnName = "提货限制")]
    public class Strategies:BaseEntity
    {
        /// <summary>
       ///策略名称
       /// </summary>
       [Display(Name ="策略名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string Strategy_Name { get; set; }

       /// <summary>
       ///是否启用
       /// </summary>
       [Display(Name ="是否启用")]
       [Column(TypeName="sbyte")]
       [Editable(true)]
       public sbyte? Enable { get; set; }

       /// <summary>
       ///策略ID
       /// </summary>
       [Key]
       [Display(Name ="策略ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Strategy_Id { get; set; }

       /// <summary>
       ///提货创建人ID
       /// </summary>
       [Display(Name ="提货创建人ID")]
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

       [Display(Name ="提货限制")]
       [ForeignKey("Strategy_Id")]
       public List<Expiredsets> Expiredsets { get; set; }

    }
}