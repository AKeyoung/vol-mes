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
    [Entity(TableCnName = "库存管理",TableName = "WMS_Stock")]
    public partial class WMS_Stock:BaseEntity
    {
        /// <summary>
       ///存放仓库
       /// </summary>
       [Display(Name ="存放仓库")]
       [Column(TypeName="int")]
       public int? WarehouseId { get; set; }

       /// <summary>
       ///批次号
       /// </summary>
       [Display(Name ="批次号")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Required(AllowEmptyStrings=false)]
       public string BatchesId { get; set; }

       /// <summary>
       ///货物类型
       /// </summary>
       [Display(Name ="货物类型")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int SkuId { get; set; }

       /// <summary>
       ///库存总量
       /// </summary>
       [Display(Name ="库存总量")]
       [DisplayFormat(DataFormatString="38,2")]
       [Column(TypeName="decimal")]
       public decimal? qty { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       public string    Static { get; set; }

       /// <summary>
       ///id
       /// </summary>
       [Key]
       [Display(Name ="id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int ID { get; set; }

       /// <summary>
       ///SGUID
       /// </summary>
       [Display(Name ="SGUID")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       public string SGUID { get; set; }

       /// <summary>
       ///租户id
       /// </summary>
       [Display(Name ="租户id")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       public string Tenant { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [Column(TypeName="int")]
       public int? CreatedBy { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreatedTime { get; set; }

       /// <summary>
       ///更新人
       /// </summary>
       [Display(Name ="更新人")]
       [Column(TypeName="int")]
       public int? UpdatedBy { get; set; }

       /// <summary>
       ///更新时间
       /// </summary>
       [Display(Name ="更新时间")]
       [Column(TypeName="datetime")]
       public DateTime? UpdatedTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Dataownership")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       public string Dataownership { get; set; }

       
    }
}