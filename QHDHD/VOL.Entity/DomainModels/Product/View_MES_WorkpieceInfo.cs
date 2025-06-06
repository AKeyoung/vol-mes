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
    [Entity(TableCnName = "生产工单",TableName = "View_MES_WorkpieceInfo",DetailTable =  new Type[] { typeof(MES_WorkpieceInfoDetail)},DetailTableCnName = "刀具明细")]
    public partial class View_MES_WorkpieceInfo:BaseEntity
    {
        /// <summary>
       ///主键
       /// </summary>
       [Key]
       [Display(Name ="主键")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int WIID { get; set; }

       /// <summary>
       ///任务号
       /// </summary>
       [Display(Name ="任务号")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string order_no { get; set; }

       /// <summary>
       ///订单
       /// </summary>
       [Display(Name ="订单")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? OrderId { get; set; }

       /// <summary>
       ///工件编号
       /// </summary>
       [Display(Name ="工件编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string WorkpieceNumber { get; set; }

       /// <summary>
       ///工件名称
       /// </summary>
       [Display(Name ="工件名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string WorkpieceName { get; set; }

       /// <summary>
       ///工序编号
       /// </summary>
       [Display(Name ="工序编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ProcessNumber { get; set; }

       /// <summary>
       ///工件材质
       /// </summary>
       [Display(Name ="工件材质")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string WorkpieceMaterial { get; set; }

       /// <summary>
       ///毛坯尺寸
       /// </summary>
       [Display(Name ="毛坯尺寸")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string BlankSize { get; set; }

       /// <summary>
       ///串联工序
       /// </summary>
       [Display(Name ="串联工序")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SeriesProcess { get; set; }

       /// <summary>
       ///机床组别
       /// </summary>
       [Display(Name ="机床组别")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string MachineGroup { get; set; }

       /// <summary>
       ///托盘类型
       /// </summary>
       [Display(Name ="托盘类型")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string PalletType { get; set; }

       /// <summary>
       ///更新日期
       /// </summary>
       [Display(Name ="更新日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? UpdateDate { get; set; }

       /// <summary>
       ///编程人员
       /// </summary>
       [Display(Name ="编程人员")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ProgrammingPerson { get; set; }

       /// <summary>
       ///程式时间
       /// </summary>
       [Display(Name ="程式时间")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ProgramTime { get; set; }

       /// <summary>
       ///图档位置
       /// </summary>
       [Display(Name ="图档位置")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string DrawingLocation { get; set; }

       /// <summary>
       ///装夹加工示图
       /// </summary>
       [Display(Name ="装夹加工示图")]
       [MaxLength(1000)]
       [Column(TypeName="varchar(1000)")]
       [Editable(true)]
       public string FixtureAndMachiningZeroDiagram { get; set; }

       /// <summary>
       ///装夹说明
       /// </summary>
       [Display(Name ="装夹说明")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string FixtureInstruction { get; set; }

       /// <summary>
       ///单夹数量
       /// </summary>
       [Display(Name ="单夹数量")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SingleFixtureQuantity { get; set; }

       /// <summary>
       ///XY零点方式
       /// </summary>
       [Display(Name ="XY零点方式")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string XYZeroMode { get; set; }

       /// <summary>
       ///Z零点方式
       /// </summary>
       [Display(Name ="Z零点方式")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ZZeroMode { get; set; }

       /// <summary>
       ///X偏置值
       /// </summary>
       [Display(Name ="X偏置值")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? XOffsetValueX2 { get; set; }

       /// <summary>
       ///Y偏置值
       /// </summary>
       [Display(Name ="Y偏置值")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? YOffsetValueY2 { get; set; }

       /// <summary>
       ///加工坐标系
       /// </summary>
       [Display(Name ="加工坐标系")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string MachiningCoordinateSystem { get; set; }

       /// <summary>
       ///零点托盘高
       /// </summary>
       [Display(Name ="零点托盘高")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? WorkpieceZeroToPalletPlaneHeightZ4 { get; set; }

       /// <summary>
       ///探头程序
       /// </summary>
       [Display(Name ="探头程序")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string ProbeProgram { get; set; }

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
       [Display(Name ="UpdateTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? UpdateTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateUser")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string CreateUser { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="UpdateUser")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string UpdateUser { get; set; }

       /// <summary>
       ///加工程序
       /// </summary>
       [Display(Name ="加工程序")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string MachiningProgram { get; set; }

       /// <summary>
       ///工单表格
       /// </summary>
       [Display(Name ="工单表格")]
       [MaxLength(1000)]
       [Column(TypeName="varchar(1000)")]
       [Editable(true)]
       public string FilesUrl { get; set; }

       /// <summary>
       ///公司名
       /// </summary>
       [Display(Name ="公司名")]
       [MaxLength(5)]
       [Column(TypeName="nvarchar(5)")]
       [Editable(true)]
       public string company_code { get; set; }

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

       [Display(Name ="刀具明细")]
       [ForeignKey("WIID")]
       public List<MES_WorkpieceInfoDetail> MES_WorkpieceInfoDetail { get; set; }

    }
}