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
    [Entity(TableCnName = "订单排产主表",TableName = "MES_ProductScheduling")]
    public partial class MES_ProductScheduling:BaseEntity
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
       ///订单Id
       /// </summary>
       [Display(Name ="订单Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? OP_ID { get; set; }

       /// <summary>
       ///状态 0：待生产，1：已完成，2：生产中，3：缺料
       /// </summary>
       [Display(Name ="状态 0：待生产，1：已完成，2：生产中，3：缺料")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Status { get; set; }

       /// <summary>
       ///程序号
       /// </summary>
       [Display(Name ="程序号")]
       [MaxLength(30)]
       [Column(TypeName="varchar(30)")]
       [Editable(true)]
       public string ProgramNum { get; set; }

       /// <summary>
       ///排序号
       /// </summary>
       [Display(Name ="排序号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SortNum { get; set; }

       /// <summary>
       ///是否启用
       /// </summary>
       [Display(Name ="是否启用")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Enable { get; set; }

       /// <summary>
       ///更新时间
       /// </summary>
       [Display(Name ="更新时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? UpdateTime { get; set; }

       /// <summary>
       ///创建用户名称
       /// </summary>
       [Display(Name ="创建用户名称")]
       [MaxLength(4000)]
       [Column(TypeName="varchar(4000)")]
       [Editable(true)]
       public string CreateUser { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateTime { get; set; }

       /// <summary>
       ///排程编号
       /// </summary>
       [Display(Name ="排程编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ProCode { get; set; }

       /// <summary>
       ///调整原因
       /// </summary>
       [Display(Name ="调整原因")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string Adjustment { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string Remarks { get; set; }

       /// <summary>
       ///排程时间
       /// </summary>
       [Display(Name ="排程时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ProductionSchedulingTime { get; set; }

       
    }
}