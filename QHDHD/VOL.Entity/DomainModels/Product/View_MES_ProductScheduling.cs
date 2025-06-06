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
    [Entity(TableCnName = "订单排产",TableName = "View_MES_ProductScheduling")]
    public partial class View_MES_ProductScheduling:BaseEntity
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
       ///
       /// </summary>
       [Display(Name ="OP_ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? OP_ID { get; set; }

       /// <summary>
       ///排程编号
       /// </summary>
       [Display(Name ="排程编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ProCode { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
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
       ///排程时间
       /// </summary>
       [Display(Name ="排程时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ProductionSchedulingTime { get; set; }

       /// <summary>
       ///是否暂停
       /// </summary>
       [Display(Name ="是否暂停")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Enable { get; set; }

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
       [Display(Name ="CreateUser")]
       [MaxLength(4000)]
       [Column(TypeName="varchar(4000)")]
       [Editable(true)]
       public string CreateUser { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateTime { get; set; }

       /// <summary>
       ///公司名
       /// </summary>
       [Display(Name ="公司名")]
       [MaxLength(5)]
       [Column(TypeName="nvarchar(5)")]
       [Editable(true)]
       public string company_code { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="rs_id")]
       [MaxLength(38)]
       [Column(TypeName="nvarchar(38)")]
       [Editable(true)]
       public string rs_id { get; set; }

       /// <summary>
       ///任务号
       /// </summary>
       [Display(Name ="任务号")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string order_no { get; set; }

       /// <summary>
       ///工序号
       /// </summary>
       [Display(Name ="工序号")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       public long? op_no { get; set; }

       /// <summary>
       ///工序名
       /// </summary>
       [Display(Name ="工序名")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string op_name { get; set; }

       /// <summary>
       ///物料编码
       /// </summary>
       [Display(Name ="物料编码")]
       [MaxLength(25)]
       [Column(TypeName="nvarchar(25)")]
       [Editable(true)]
       public string item_code { get; set; }

       /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string item_name { get; set; }

       /// <summary>
       ///规格型号
       /// </summary>
       [Display(Name ="规格型号")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string item_model { get; set; }

       /// <summary>
       ///图号
       /// </summary>
       [Display(Name ="图号")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string item_norm { get; set; }

       /// <summary>
       ///计划数量
       /// </summary>
       [Display(Name ="计划数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? plan_qty { get; set; }

       /// <summary>
       ///工作令号
       /// </summary>
       [Display(Name ="工作令号")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string work_no { get; set; }

       /// <summary>
       ///计划号
       /// </summary>
       [Display(Name ="计划号")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string plan_no { get; set; }

       /// <summary>
       ///客户编码
       /// </summary>
       [Display(Name ="客户编码")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string customer_code { get; set; }

       /// <summary>
       ///客户名称
       /// </summary>
       [Display(Name ="客户名称")]
       [MaxLength(60)]
       [Column(TypeName="nvarchar(60)")]
       [Editable(true)]
       public string customer_name { get; set; }

       /// <summary>
       ///计量单位
       /// </summary>
       [Display(Name ="计量单位")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string unit_code { get; set; }

       /// <summary>
       ///计量名称
       /// </summary>
       [Display(Name ="计量名称")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string unit_name { get; set; }

       /// <summary>
       ///责任部门编码
       /// </summary>
       [Display(Name ="责任部门编码")]
       [MaxLength(5)]
       [Column(TypeName="nvarchar(5)")]
       [Editable(true)]
       public string dept_code { get; set; }

       /// <summary>
       ///责任部门名称
       /// </summary>
       [Display(Name ="责任部门名称")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string dept_name { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(8)]
       [Column(TypeName="nvarchar(8)")]
       [Editable(true)]
       public string wc_code { get; set; }

       /// <summary>
       ///工位名称
       /// </summary>
       [Display(Name ="工位名称")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string wc_name { get; set; }

       /// <summary>
       ///计划开始时间
       /// </summary>
       [Display(Name ="计划开始时间")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string start_date { get; set; }

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

       
    }
}