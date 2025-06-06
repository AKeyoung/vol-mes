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
    [Entity(TableCnName = "设备保养",TableName = "View_MES_Conserve")]
    public partial class View_MES_Conserve:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
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
       public string DeviceId { get; set; }

       /// <summary>
       ///设备名称
       /// </summary>
       [Display(Name ="设备名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string Name { get; set; }

       /// <summary>
       ///序列号
       /// </summary>
       [Display(Name ="序列号")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string EquipSn { get; set; }

       /// <summary>
       ///品牌
       /// </summary>
       [Display(Name ="品牌")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Brand { get; set; }

       /// <summary>
       ///规格型号
       /// </summary>
       [Display(Name ="规格型号")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Model { get; set; }

       /// <summary>
       ///供应商
       /// </summary>
       [Display(Name ="供应商")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Supplier { get; set; }

       /// <summary>
       ///供应商地址
       /// </summary>
       [Display(Name ="供应商地址")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
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
       ///入场时间
       /// </summary>
       [Display(Name ="入场时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? InDate { get; set; }

       /// <summary>
       ///保养计划
       /// </summary>
       [Display(Name ="保养计划")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string ConPlan { get; set; }

       /// <summary>
       ///保养类型
       /// </summary>
       [Display(Name ="保养类型")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string ConType { get; set; }

       /// <summary>
       ///开始时间
       /// </summary>
       [Display(Name ="开始时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime StartTime { get; set; }

       /// <summary>
       ///结束时间
       /// </summary>
       [Display(Name ="结束时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime EndTime { get; set; }

       /// <summary>
       ///保养内容
       /// </summary>
       [Display(Name ="保养内容")]
       [MaxLength(5000)]
       [Column(TypeName="varchar(5000)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Remarks { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ReserveOne")]
       [MaxLength(4000)]
       [Column(TypeName="varchar(4000)")]
       [Editable(true)]
       public string ReserveOne { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ReserveTwo")]
       [MaxLength(4000)]
       [Column(TypeName="varchar(4000)")]
       [Editable(true)]
       public string ReserveTwo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ReserveThree")]
       [MaxLength(4000)]
       [Column(TypeName="varchar(4000)")]
       [Editable(true)]
       public string ReserveThree { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ReserveFour")]
       [MaxLength(4000)]
       [Column(TypeName="varchar(4000)")]
       [Editable(true)]
       public string ReserveFour { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ReserveFive")]
       [MaxLength(4000)]
       [Column(TypeName="varchar(4000)")]
       [Editable(true)]
       public string ReserveFive { get; set; }

       /// <summary>
       ///更新人
       /// </summary>
       [Display(Name ="更新人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string UpdateUser { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string CreateUser { get; set; }

       /// <summary>
       ///更新时间
       /// </summary>
       [Display(Name ="更新时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? UpdateTime { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateTime { get; set; }

       /// <summary>
       ///保养文件
       /// </summary>
       [Display(Name ="保养文件")]
       [MaxLength(300)]
       [Column(TypeName="varchar(300)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FilesUrl { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="EquipID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? EquipID { get; set; }

       
    }
}