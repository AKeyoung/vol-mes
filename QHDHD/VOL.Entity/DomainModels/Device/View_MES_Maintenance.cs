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
    [Entity(TableCnName = "设备维修",TableName = "View_MES_Maintenance")]
    public partial class View_MES_Maintenance:BaseEntity
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
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int DeviceId { get; set; }

       /// <summary>
       ///设备名称
       /// </summary>
       [Display(Name ="设备名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
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
       ///规格信号
       /// </summary>
       [Display(Name ="规格信号")]
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
       ///维修类型
       /// </summary>
       [Display(Name ="维修类型")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string MainType { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(5000)]
       [Column(TypeName="varchar(5000)")]
       [Editable(true)]
       public string Remarks { get; set; }

       /// <summary>
       ///相关图片
       /// </summary>
       [Display(Name ="相关图片")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string MainFiles { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="UpdateUser")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string UpdateUser { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateUser")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string CreateUser { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="UpdateTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? UpdateTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="EquipID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? EquipID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="InDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? InDate { get; set; }

       
    }
}