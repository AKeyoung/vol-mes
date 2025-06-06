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
    [Entity(TableCnName = "报工管理",TableName = "MES_Report_Work")]
    public partial class MES_Report_Work:BaseEntity
    {
        /// <summary>
       ///报工记录ID
       /// </summary>
       [Key]
       [Display(Name ="报工记录ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Report_ID { get; set; }

       /// <summary>
       ///工单编号
       /// </summary>
       [Display(Name ="工单编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Work_Order_No { get; set; }

       /// <summary>
       ///工序编号
       /// </summary>
       [Display(Name ="工序编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Process_No { get; set; }

       /// <summary>
       ///员工编号
       /// </summary>
       [Display(Name ="员工编号")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       public string User_ID { get; set; }

       /// <summary>
       ///设备编号
       /// </summary>
       [Display(Name ="设备编号")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       public string Equipment_ID { get; set; }

       /// <summary>
       ///班次
       /// </summary>
       [Display(Name ="班次")]
       [MaxLength(10)]
       [Column(TypeName="varchar(10)")]
       [Editable(true)]
       public string Shift { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Qty")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Qty { get; set; }

       /// <summary>
       ///良品数量
       /// </summary>
       [Display(Name ="良品数量")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Good_Qty { get; set; }

       /// <summary>
       ///次品数量
       /// </summary>
       [Display(Name ="次品数量")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Defective_Qty { get; set; }

       /// <summary>
       ///废品数量
       /// </summary>
       [Display(Name ="废品数量")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Scrap_Qty { get; set; }

       /// <summary>
       ///开工时间
       /// </summary>
       [Display(Name ="开工时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? Start_Time { get; set; }

       /// <summary>
       ///完工时间
       /// </summary>
       [Display(Name ="完工时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? End_Time { get; set; }

       /// <summary>
       ///审核时间
       /// </summary>
       [Display(Name ="审核时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? Audit_Time { get; set; }

       /// <summary>
       ///审核人
       /// </summary>
       [Display(Name ="审核人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Auditor { get; set; }

       /// <summary>
       ///报工状态
       /// </summary>
       [Display(Name ="报工状态")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       public byte? Report_Status { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///创建人ID
       /// </summary>
       [Display(Name ="创建人ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改人ID
       /// </summary>
       [Display(Name ="修改人ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       
    }
}