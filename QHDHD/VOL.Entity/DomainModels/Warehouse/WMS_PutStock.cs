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
    [Entity(TableCnName = "出库管理",TableName = "WMS_PutStock")]
    public partial class WMS_PutStock:BaseEntity
    {
        /// <summary>
       ///id
       /// </summary>
       [Key]
       [Display(Name ="id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int ID { get; set; }

       /// <summary>
       ///SGUID
       /// </summary>
       [Display(Name ="SGUID")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       public string Sguid { get; set; }

       /// <summary>
       ///租户id
       /// </summary>
       [Display(Name ="租户id")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       public string Tenant { get; set; }

       /// <summary>
       ///单据编号
       /// </summary>
       [Display(Name ="单据编号")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       public string putno { get; set; }

       /// <summary>
       ///单据类型
       /// </summary>
       [Display(Name ="单据类型")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? type { get; set; }

       /// <summary>
       ///出入库类型
       /// </summary>
       [Display(Name ="出入库类型")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       public string InoutType { get; set; }

       /// <summary>
       ///单据状态
       /// </summary>
       [Display(Name ="单据状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Static { get; set; }

       /// <summary>
       ///发货组织
       /// </summary>
       [Display(Name ="发货组织")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       public string DeliveryOrg { get; set; }

       /// <summary>
       ///发货时间
       /// </summary>
       [Display(Name ="发货时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? DeliveryTime { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(2000)]
       [Column(TypeName="varchar(2000)")]
       [Editable(true)]
       public string remark { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreatedBy { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreatedTime { get; set; }

       /// <summary>
       ///更新人
       /// </summary>
       [Display(Name ="更新人")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? UpdatedBy { get; set; }

       /// <summary>
       ///更新时间
       /// </summary>
       [Display(Name ="更新时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? UpdatedTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isQualified")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? isQualified { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CustomerId")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       public string CustomerId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Dataownership")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       public string Dataownership { get; set; }

       
    }
}