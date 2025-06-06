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
    [Entity(TableCnName = "设备信息",TableName = "MES_Equip")]
    public partial class MES_Equip:BaseEntity
    {
        /// <summary>
       ///主键
       /// </summary>
       [Key]
       [Display(Name ="主键")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///设备名称
       /// </summary>
       [Display(Name ="设备名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Name { get; set; }

       /// <summary>
       ///序列号
       /// </summary>
       [Display(Name ="序列号")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string SN { get; set; }

       /// <summary>
       ///品牌
       /// </summary>
       [Display(Name ="品牌")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Brand { get; set; }

       /// <summary>
       ///规格型号
       /// </summary>
       [Display(Name ="规格型号")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Model { get; set; }

       /// <summary>
       ///质保到期日
       /// </summary>
       [Display(Name ="质保到期日")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? QCEndDate { get; set; }

       /// <summary>
       ///供应商
       /// </summary>
       [Display(Name ="供应商")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Supplier { get; set; }

       /// <summary>
       ///供应商地址
       /// </summary>
       [Display(Name ="供应商地址")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string SupplierAddress { get; set; }

       /// <summary>
       ///供应商电话
       /// </summary>
       [Display(Name ="供应商电话")]
       [MaxLength(30)]
       [Column(TypeName="varchar(30)")]
       [Editable(true)]
       public string SupplierPhone { get; set; }

       /// <summary>
       ///入厂时间
       /// </summary>
       [Display(Name ="入厂时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime InDate { get; set; }

       /// <summary>
       ///关键设备
       /// </summary>
       [Display(Name ="关键设备")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string IsPivotal { get; set; }

       /// <summary>
       ///易损设备
       /// </summary>
       [Display(Name ="易损设备")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string IsVulnerable { get; set; }

       /// <summary>
       ///IP地址
       /// </summary>
       [Display(Name ="IP地址")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Ip { get; set; }

       /// <summary>
       ///MAC
       /// </summary>
       [Display(Name ="MAC")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string MAC { get; set; }

       
    }
}