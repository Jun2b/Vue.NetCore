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
    [Entity(TableCnName = "商家设置",TableName = "Shops")]
    public class Shops:BaseEntity
    {
        /// <summary>
       ///商家名称
       /// </summary>
       [Display(Name ="商家名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string ShopName { get; set; }

       /// <summary>
       ///商家用户名
       /// </summary>
       [Display(Name ="商家用户名")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int User_Id { get; set; }

       /// <summary>
       ///卡号前缀
       /// </summary>
       [Display(Name ="卡号前缀")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Prefix { get; set; }

       /// <summary>
       ///卡号中段
       /// </summary>
       [Display(Name ="卡号中段")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Middle { get; set; }

       /// <summary>
       ///服务电话
       /// </summary>
       [Display(Name ="服务电话")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string ServePhone { get; set; }

       /// <summary>
       ///短信剩余
       /// </summary>
       [Display(Name ="短信剩余")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SMS_Qty { get; set; }

       /// <summary>
       ///开放日期
       /// </summary>
       [Display(Name ="开放日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? OpenDateStart { get; set; }

       /// <summary>
       ///关闭日期
       /// </summary>
       [Display(Name ="关闭日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? OpenDateEnd { get; set; }

       /// <summary>
       ///系统关闭提示信息
       /// </summary>
       [Display(Name ="系统关闭提示信息")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string Message { get; set; }

       /// <summary>
       ///预约开始
       /// </summary>
       [Display(Name ="预约开始")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? OrderDateStart { get; set; }

       /// <summary>
       ///预约结束
       /// </summary>
       [Display(Name ="预约结束")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? OrderDateEnd { get; set; }

       /// <summary>
       ///预约时间点
       /// </summary>
       [Display(Name ="预约时间点")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Deadline { get; set; }

       /// <summary>
       ///提货公告
       /// </summary>
       [Display(Name ="提货公告")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Announcement { get; set; }

       /// <summary>
       ///提货首页图片
       /// </summary>
       [Display(Name ="提货首页图片")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string BannerImg { get; set; }

       /// <summary>
       ///店铺ID
       /// </summary>
       [Key]
       [Display(Name ="店铺ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Shops_Id { get; set; }

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