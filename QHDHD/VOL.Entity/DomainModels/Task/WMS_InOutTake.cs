/********************************
 *
 * 文 件 名:   $safeitemname$
 * 创 建 者：  $username$
 * 创建时间：  $time$
 *
********************************/
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
    [Entity(TableCnName = "单据管理",TableName = "WMS_InOutTake")]
    public partial class WMS_InOutTake:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int id { get; set; }

       /// <summary>
       ///申请单号
       /// </summary>
       [Display(Name ="申请单号")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ApplicationOrder { get; set; }

       /// <summary>
       ///申请日期
       /// </summary>
       [Display(Name ="申请日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? ApplicationTime { get; set; }

       /// <summary>
       ///申请人
       /// </summary>
       [Display(Name ="申请人")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ApplicationPerson { get; set; }

       /// <summary>
       ///申请部门
       /// </summary>
       [Display(Name ="申请部门")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string ApplicationDepart { get; set; }

       /// <summary>
       ///申请日期
       /// </summary>
       [Display(Name ="申请日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? ExpectedOutTime { get; set; }

       /// <summary>
       ///申请数量
       /// </summary>
       [Display(Name ="申请数量")]
       [DisplayFormat(DataFormatString="36,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? ApplicationQty { get; set; }

       /// <summary>
       ///用途说明
       /// </summary>
       [Display(Name ="用途说明")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string DescriptionPurpose { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string Remarks { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="int")]
       public int? Static { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Sguid")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       public string Sguid { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="InOutTakeStatic")]
       [Column(TypeName="int")]
       public int? InOutTakeStatic { get; set; }

       
    }
}