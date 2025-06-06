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
    [Entity(TableCnName = "入库管理",TableName = "QHD_material")]
    public partial class QHD_material:BaseEntity
    {
        /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string StuId { get; set; }

       /// <summary>
       ///刀具名称
       /// </summary>
       [Display(Name ="刀具名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Name { get; set; }

       /// <summary>
       ///批次号
       /// </summary>
       [Display(Name ="批次号")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string BatchNumber { get; set; }

       /// <summary>
       ///刀具型号
       /// </summary>
       [Display(Name ="刀具型号")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Model { get; set; }

       /// <summary>
       ///SN码
       /// </summary>
       [Display(Name ="SN码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string SN { get; set; }

       /// <summary>
       ///类型
       /// </summary>
       [Display(Name ="类型")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Type { get; set; }

       /// <summary>
       ///仓库名称
       /// </summary>
       [Display(Name ="仓库名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string WarehouseName { get; set; }

       /// <summary>
       ///入库数量
       /// </summary>
       [Display(Name ="入库数量")]
       [DisplayFormat(DataFormatString="18,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? Qty { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Static { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? CreateTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="IsAssembly")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string IsAssembly { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Sguid")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string Sguid { get; set; }

       /// <summary>
       ///仓库id
       /// </summary>
       [Display(Name ="仓库id")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string WarehouseId { get; set; }

       
    }
}