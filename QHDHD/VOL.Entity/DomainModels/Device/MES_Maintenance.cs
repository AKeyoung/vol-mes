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
    [Entity(TableCnName = "设备维修",TableName = "MES_Maintenance")]
    public partial class MES_Maintenance:BaseEntity
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
       ///设备
       /// </summary>
       [Display(Name ="设备")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? DeviceId { get; set; }

       /// <summary>
       ///维修类型
       /// </summary>
       [Display(Name ="维修类型")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string MainType { get; set; }

       /// <summary>
       ///相关图片
       /// </summary>
       [Display(Name ="相关图片")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string MainFiles { get; set; }

       /// <summary>
       ///描述
       /// </summary>
       [Display(Name ="描述")]
       [MaxLength(5000)]
       [Column(TypeName="varchar(5000)")]
       [Editable(true)]
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

       
    }
}