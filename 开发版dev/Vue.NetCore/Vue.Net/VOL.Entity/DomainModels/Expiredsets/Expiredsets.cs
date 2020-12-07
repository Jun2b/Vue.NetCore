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
    [Entity(TableCnName = "提货限制",TableName = "Expiredsets")]
    public class Expiredsets:BaseEntity
    {
        /// <summary>
       ///策略ID
       /// </summary>
       [Display(Name ="策略ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Strategy_Id { get; set; }

       /// <summary>
       ///提货日期
       /// </summary>
       [Display(Name ="提货日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? OrderDate { get; set; }

       /// <summary>
       ///限制数量
       /// </summary>
       [Display(Name ="限制数量")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? MaxQty { get; set; }

       /// <summary>
       ///超限提示
       /// </summary>
       [Display(Name ="超限提示")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string Message { get; set; }

       /// <summary>
       ///限制ID
       /// </summary>
       [Key]
       [Display(Name ="限制ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Expiredset_Id { get; set; }

       /// <summary>
       ///限制创建人ID
       /// </summary>
       [Display(Name ="限制创建人ID")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int CreateID { get; set; }

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
