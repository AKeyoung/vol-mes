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
    [Entity(TableCnName = "生产订单",TableName = "Pac_Routing_Op")]
    public partial class Pac_Routing_Op:BaseEntity
    {
        /// <summary>
       ///主键
       /// </summary>
       [Key]
       [Display(Name ="主键")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int ID { get; set; }

       /// <summary>
       ///公司名
       /// </summary>
       [Display(Name ="公司名")]
       [MaxLength(5)]
       [Column(TypeName="nvarchar(5)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
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
       [Required(AllowEmptyStrings=false)]
       public string order_no { get; set; }

       /// <summary>
       ///工序号
       /// </summary>
       [Display(Name ="工序号")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public long op_no { get; set; }

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
       ///计划结束时间
       /// </summary>
       [Display(Name ="计划结束时间")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string due_date { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="urgency_flag")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string urgency_flag { get; set; }

       /// <summary>
       ///工时（小时）
       /// </summary>
       [Display(Name ="工时（小时）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? plan_hours { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="wc_abv")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string wc_abv { get; set; }

       /// <summary>
       ///工种编码
       /// </summary>
       [Display(Name ="工种编码")]
       [MaxLength(2)]
       [Column(TypeName="nvarchar(2)")]
       [Editable(true)]
       public string job_kind { get; set; }

       /// <summary>
       ///工种名称
       /// </summary>
       [Display(Name ="工种名称")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string job_kind_name { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="earlist_date_s")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string earlist_date_s { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="earlist_date_d")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string earlist_date_d { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="latest_date_s")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string latest_date_s { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="latest_date_d")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string latest_date_d { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="priority")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       public long? priority { get; set; }

       /// <summary>
       ///首末序标记
       /// </summary>
       [Display(Name ="首末序标记")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string first_last { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="cost_op")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string cost_op { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="sfc_op")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string sfc_op { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="cap_op")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string cap_op { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="check_op")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string check_op { get; set; }

       /// <summary>
       ///质检标记
       /// </summary>
       [Display(Name ="质检标记")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string qc_flag { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="op_flag")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string op_flag { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="setup_time")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? setup_time { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="setup_unit")]
       [MaxLength(2)]
       [Column(TypeName="nvarchar(2)")]
       [Editable(true)]
       public string setup_unit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="run_time")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? run_time { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="run_unit")]
       [MaxLength(2)]
       [Column(TypeName="nvarchar(2)")]
       [Editable(true)]
       public string run_unit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="over_load")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? over_load { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="post_time")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? post_time { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="post_unit")]
       [MaxLength(2)]
       [Column(TypeName="nvarchar(2)")]
       [Editable(true)]
       public string post_unit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="provide_nums")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       public long? provide_nums { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="overlaped")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string overlaped { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="move_qty")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? move_qty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="over_rate")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? over_rate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="move_days")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       public long? move_days { get; set; }

       /// <summary>
       ///外协标记
       /// </summary>
       [Display(Name ="外协标记")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string coop_flag { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="coop_code")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string coop_code { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="coop_name")]
       [MaxLength(60)]
       [Column(TypeName="nvarchar(60)")]
       [Editable(true)]
       public string coop_name { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="coop_op_cost")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? coop_op_cost { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="coop_actual_cost")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? coop_actual_cost { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="coop_hours")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? coop_hours { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="tool_desc")]
       [MaxLength(60)]
       [Column(TypeName="nvarchar(60)")]
       [Editable(true)]
       public string tool_desc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="tool_flag")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string tool_flag { get; set; }

       /// <summary>
       ///工作令
       /// </summary>
       [Display(Name ="工作令")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string customer_order { get; set; }

       /// <summary>
       ///工序部门编码
       /// </summary>
       [Display(Name ="工序部门编码")]
       [MaxLength(5)]
       [Column(TypeName="nvarchar(5)")]
       [Editable(true)]
       public string dept_code_wc { get; set; }

       /// <summary>
       ///工序部门名称
       /// </summary>
       [Display(Name ="工序部门名称")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string dept_name_wc { get; set; }

       /// <summary>
       ///工艺流转码
       /// </summary>
       [Display(Name ="工艺流转码")]
       [MaxLength(60)]
       [Column(TypeName="nvarchar(60)")]
       [Editable(true)]
       public string note { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="start_flag")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string start_flag { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="due_flag")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string due_flag { get; set; }

       /// <summary>
       ///实际开工时间
       /// </summary>
       [Display(Name ="实际开工时间")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string actual_start_date { get; set; }

       /// <summary>
       ///实际完工时间
       /// </summary>
       [Display(Name ="实际完工时间")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string actual_end_date { get; set; }

       /// <summary>
       ///累计完成数量
       /// </summary>
       [Display(Name ="累计完成数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? accum_qty { get; set; }

       /// <summary>
       ///废品数量
       /// </summary>
       [Display(Name ="废品数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? scrap_qty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="grade_qty_1")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? grade_qty_1 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="grade_qty_2")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? grade_qty_2 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="grade_qty_3")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? grade_qty_3 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="grade_qty_4")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? grade_qty_4 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="grade_qty_5")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? grade_qty_5 { get; set; }

       /// <summary>
       ///实际工时（小时）
       /// </summary>
       [Display(Name ="实际工时（小时）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? actual_hours { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="scrap_hours")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? scrap_hours { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="m_scrap_hours")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? m_scrap_hours { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="revise_qty")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? revise_qty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="revise_hours")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? revise_hours { get; set; }

       /// <summary>
       ///工序状态
       /// </summary>
       [Display(Name ="工序状态")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string op_status { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="assist_unit")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string assist_unit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="assist_name")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string assist_name { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="assist_plan_qty")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? assist_plan_qty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="assist_actual_qty")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? assist_actual_qty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="idle_hours")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? idle_hours { get; set; }

       /// <summary>
       ///考核字段
       /// </summary>
       [Display(Name ="考核字段")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string rs_char1 { get; set; }

       /// <summary>
       ///下料小于10件免检备注、涂装说明
       /// </summary>
       [Display(Name ="下料小于10件免检备注、涂装说明")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string rs_char2 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="rs_int1")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       public long? rs_int1 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="rs_int2")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       public long? rs_int2 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="rs_float1")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? rs_float1 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="rs_float2")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? rs_float2 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="priority_t")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? priority_t { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="other_hours")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? other_hours { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ration_hours")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ration_hours { get; set; }

       /// <summary>
       ///外协类型071224add jfm 当外协标记=Y，值为M-加工类外协；否则空
       /// </summary>
       [Display(Name ="外协类型071224add jfm 当外协标记=Y，值为M-加工类外协；否则空")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string coop_type { get; set; }

       /// <summary>
       ///协议号071224add jfm 从采购协议中选择 
       /// </summary>
       [Display(Name ="协议号071224add jfm 从采购协议中选择 ")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string agreement_no { get; set; }

       /// <summary>
       ///协议行号071224add jfm 从采购协议中选择
       /// </summary>
       [Display(Name ="协议行号071224add jfm 从采购协议中选择")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       public long? a_seq_no { get; set; }

       /// <summary>
       ///调为外协数量071224add jfm 
       /// </summary>
       [Display(Name ="调为外协数量071224add jfm ")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? coop_qty { get; set; }

       /// <summary>
       ///单件标记
       /// </summary>
       [Display(Name ="单件标记")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string unique_flag { get; set; }

       /// <summary>
       ///报工标记
       /// </summary>
       [Display(Name ="报工标记")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string invoice_flag { get; set; }

       /// <summary>
       ///报工数量
       /// </summary>
       [Display(Name ="报工数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? invoice_actual_qty { get; set; }

       /// <summary>
       ///实际工时
       /// </summary>
       [Display(Name ="实际工时")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? invoice_actual_hours { get; set; }

       /// <summary>
       ///工废数量
       /// </summary>
       [Display(Name ="工废数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? invoice_scrap_qty { get; set; }

       /// <summary>
       ///工废工时
       /// </summary>
       [Display(Name ="工废工时")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? invoice_scrap_hours { get; set; }

       /// <summary>
       ///料废数量
       /// </summary>
       [Display(Name ="料废数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? invoice_m_scrap_qty { get; set; }

       /// <summary>
       ///料废工时
       /// </summary>
       [Display(Name ="料废工时")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? invoice_m_scrap_hours { get; set; }

       /// <summary>
       ///产生新件生产任务标记
       /// </summary>
       [Display(Name ="产生新件生产任务标记")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string invoice_scrap_pac_flag { get; set; }

       /// <summary>
       ///操作工
       /// </summary>
       [Display(Name ="操作工")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string invoice_duty_man { get; set; }

       /// <summary>
       ///操作工姓名
       /// </summary>
       [Display(Name ="操作工姓名")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string invoice_duty_name { get; set; }

       /// <summary>
       ///实际开工日期
       /// </summary>
       [Display(Name ="实际开工日期")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string invoice_start_date { get; set; }

       /// <summary>
       ///实际完工日期
       /// </summary>
       [Display(Name ="实际完工日期")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string invoice_end_date { get; set; }

       /// <summary>
       ///统计员
       /// </summary>
       [Display(Name ="统计员")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string invoice_staff_code { get; set; }

       /// <summary>
       ///统计员姓名
       /// </summary>
       [Display(Name ="统计员姓名")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string invoice_staff_name { get; set; }

       /// <summary>
       ///检验员
       /// </summary>
       [Display(Name ="检验员")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string invoice_check_man { get; set; }

       /// <summary>
       ///检验员姓名
       /// </summary>
       [Display(Name ="检验员姓名")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string invoice_check_name { get; set; }

       /// <summary>
       ///报工日期
       /// </summary>
       [Display(Name ="报工日期")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string invoice_record_date { get; set; }

       /// <summary>
       ///报工类型
       /// </summary>
       [Display(Name ="报工类型")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string invoice_kind_code { get; set; }

       /// <summary>
       ///旧件标记
       /// </summary>
       [Display(Name ="旧件标记")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string new_old_flag { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="op_class")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string op_class { get; set; }

       /// <summary>
       ///接收数量
       /// </summary>
       [Display(Name ="接收数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? i_qty { get; set; }

       /// <summary>
       ///交出数量
       /// </summary>
       [Display(Name ="交出数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? o_qty { get; set; }

       /// <summary>
       ///单位折算工时
       /// </summary>
       [Display(Name ="单位折算工时")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? rate_unit_hours { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="norm_unit_hours")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? norm_unit_hours { get; set; }

       /// <summary>
       ///已派工量
       /// </summary>
       [Display(Name ="已派工量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? appoint_accum_qty { get; set; }

       /// <summary>
       ///互检控制标记
       /// </summary>
       [Display(Name ="互检控制标记")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string mutual_check_flag { get; set; }

       /// <summary>
       ///编制单位
       /// </summary>
       [Display(Name ="编制单位")]
       [MaxLength(2)]
       [Column(TypeName="nvarchar(2)")]
       [Editable(true)]
       public string routing_schedual_unit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="order_adjust_flag")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string order_adjust_flag { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="explosion_flag")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string explosion_flag { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="start_shift_seq_s")]
       [MaxLength(5)]
       [Column(TypeName="nvarchar(5)")]
       [Editable(true)]
       public string start_shift_seq_s { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="start_shift_desc_s")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string start_shift_desc_s { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="end_shift_seq_s")]
       [MaxLength(5)]
       [Column(TypeName="nvarchar(5)")]
       [Editable(true)]
       public string end_shift_seq_s { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="end_shift_desc_s")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string end_shift_desc_s { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="start_shift_seq_e")]
       [MaxLength(5)]
       [Column(TypeName="nvarchar(5)")]
       [Editable(true)]
       public string start_shift_seq_e { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="start_shift_desc_e")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string start_shift_desc_e { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="end_shift_seq_e")]
       [MaxLength(5)]
       [Column(TypeName="nvarchar(5)")]
       [Editable(true)]
       public string end_shift_seq_e { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="end_shift_desc_e")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string end_shift_desc_e { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="pause_flag")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string pause_flag { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="actual_start_time")]
       [MaxLength(9)]
       [Column(TypeName="nvarchar(9)")]
       [Editable(true)]
       public string actual_start_time { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="actual_end_time")]
       [MaxLength(9)]
       [Column(TypeName="nvarchar(9)")]
       [Editable(true)]
       public string actual_end_time { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="actual_start_shift")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string actual_start_shift { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="actual_end_shift")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string actual_end_shift { get; set; }

       /// <summary>
       ///外协工序要求送回日期
       /// </summary>
       [Display(Name ="外协工序要求送回日期")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string return_date { get; set; }

       /// <summary>
       ///班组派工原工作中心
       /// </summary>
       [Display(Name ="班组派工原工作中心")]
       [MaxLength(8)]
       [Column(TypeName="nvarchar(8)")]
       [Editable(true)]
       public string wc_code_old { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="wc_name_old")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string wc_name_old { get; set; }

       /// <summary>
       ///选择人id
       /// </summary>
       [Display(Name ="选择人id")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string select_id { get; set; }

       /// <summary>
       ///点选标记
       /// </summary>
       [Display(Name ="点选标记")]
       [MaxLength(1)]
       [Column(TypeName="nvarchar(1)")]
       [Editable(true)]
       public string select_flag { get; set; }

       /// <summary>
       ///交接录入时间--交接单确认时写入
       /// </summary>
       [Display(Name ="交接录入时间--交接单确认时写入")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string bill_time { get; set; }

       /// <summary>
       ///交出人编码
       /// </summary>
       [Display(Name ="交出人编码")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string send_man_code { get; set; }

       /// <summary>
       ///交出人姓名
       /// </summary>
       [Display(Name ="交出人姓名")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string send_man_name { get; set; }

       /// <summary>
       ///审核人编码
       /// </summary>
       [Display(Name ="审核人编码")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string con_man_code { get; set; }

       /// <summary>
       ///审核人姓名
       /// </summary>
       [Display(Name ="审核人姓名")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string con_man_name { get; set; }

       /// <summary>
       ///审核时间
       /// </summary>
       [Display(Name ="审核时间")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string con_time { get; set; }

       /// <summary>
       ///交出工序部门
       /// </summary>
       [Display(Name ="交出工序部门")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string send_dept_code_wc { get; set; }

       /// <summary>
       ///交出工序部门名称
       /// </summary>
       [Display(Name ="交出工序部门名称")]
       [MaxLength(60)]
       [Column(TypeName="nvarchar(60)")]
       [Editable(true)]
       public string send_dept_name_wc { get; set; }

       /// <summary>
       ///接收工序部门
       /// </summary>
       [Display(Name ="接收工序部门")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string rece_dept_code_wc { get; set; }

       /// <summary>
       ///接收工序部门名称
       /// </summary>
       [Display(Name ="接收工序部门名称")]
       [MaxLength(60)]
       [Column(TypeName="nvarchar(60)")]
       [Editable(true)]
       public string rece_dept_name_wc { get; set; }

       /// <summary>
       ///交接数量
       /// </summary>
       [Display(Name ="交接数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? send_qty { get; set; }

       /// <summary>
       ///接收确认时间
       /// </summary>
       [Display(Name ="接收确认时间")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string rece_time { get; set; }

       /// <summary>
       ///接收人编码
       /// </summary>
       [Display(Name ="接收人编码")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string rece_man_code { get; set; }

       /// <summary>
       ///接收人姓名
       /// </summary>
       [Display(Name ="接收人姓名")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string rece_man_name { get; set; }

       /// <summary>
       ///记账人编码
       /// </summary>
       [Display(Name ="记账人编码")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string staff_man_code { get; set; }

       /// <summary>
       ///记账人姓名
       /// </summary>
       [Display(Name ="记账人姓名")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string staff_man_name { get; set; }

       /// <summary>
       ///记账时间
       /// </summary>
       [Display(Name ="记账时间")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string staff_time { get; set; }

       /// <summary>
       ///派工日期
       /// </summary>
       [Display(Name ="派工日期")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string app_date { get; set; }

       /// <summary>
       ///派工周期
       /// </summary>
       [Display(Name ="派工周期")]
       [MaxLength(19)]
       [Column(TypeName="nvarchar(19)")]
       [Editable(true)]
       public string app_period { get; set; }

       /// <summary>
       ///派工人
       /// </summary>
       [Display(Name ="派工人")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string app_people { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="wc_codebak")]
       [MaxLength(8)]
       [Column(TypeName="nvarchar(8)")]
       [Editable(true)]
       public string wc_codebak { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="wc_namebak")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string wc_namebak { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="dept_codewcbak")]
       [MaxLength(5)]
       [Column(TypeName="nvarchar(5)")]
       [Editable(true)]
       public string dept_codewcbak { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="dept_namewcbak")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string dept_namewcbak { get; set; }

       /// <summary>
       ///开工人
       /// </summary>
       [Display(Name ="开工人")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string start_people { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="check_jx")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string check_jx { get; set; }

       /// <summary>
       ///下序工作中心
       /// </summary>
       [Display(Name ="下序工作中心")]
       [MaxLength(18)]
       [Column(TypeName="nvarchar(18)")]
       [Editable(true)]
       public string rs_char3 { get; set; }

       /// <summary>
       ///APS写入标记
       /// </summary>
       [Display(Name ="APS写入标记")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string aps_write { get; set; }

       /// <summary>
       ///APS写入时间
       /// </summary>
       [Display(Name ="APS写入时间")]
       [MaxLength(21)]
       [Column(TypeName="nvarchar(21)")]
       [Editable(true)]
       public string write_time { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="aps_remarks")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string aps_remarks { get; set; }

       /// <summary>
       ///打印标记
       /// </summary>
       [Display(Name ="打印标记")]
       [MaxLength(2)]
       [Column(TypeName="nvarchar(2)")]
       [Editable(true)]
       public string print1_flag { get; set; }

       /// <summary>
       ///APS更新时间标记
       /// </summary>
       [Display(Name ="APS更新时间标记")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string aps_up_flag { get; set; }

       /// <summary>
       ///APS更新时间时间
       /// </summary>
       [Display(Name ="APS更新时间时间")]
       [MaxLength(21)]
       [Column(TypeName="nvarchar(21)")]
       [Editable(true)]
       public string aps_up_time { get; set; }

       /// <summary>
       ///打印时间
       /// </summary>
       [Display(Name ="打印时间")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string print1_time { get; set; }

       /// <summary>
       ///打印次数
       /// </summary>
       [Display(Name ="打印次数")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? print1_nums { get; set; }

       /// <summary>
       ///20210321更新数据备注
       /// </summary>
       [Display(Name ="20210321更新数据备注")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string aps_up_remarks { get; set; }

       /// <summary>
       ///记录3月21同步前日期和APS第一次传入日期
       /// </summary>
       [Display(Name ="记录3月21同步前日期和APS第一次传入日期")]
       [MaxLength(21)]
       [Column(TypeName="nvarchar(21)")]
       [Editable(true)]
       public string latest_date_aps_s { get; set; }

       /// <summary>
       ///记录3月21同步前日期和APS第一次传入日期
       /// </summary>
       [Display(Name ="记录3月21同步前日期和APS第一次传入日期")]
       [MaxLength(21)]
       [Column(TypeName="nvarchar(21)")]
       [Editable(true)]
       public string latest_date_aps_d { get; set; }

       /// <summary>
       ///APS锁定标记
       /// </summary>
       [Display(Name ="APS锁定标记")]
       [MaxLength(2)]
       [Column(TypeName="nvarchar(2)")]
       [Editable(true)]
       public string lock_flag { get; set; }

       /// <summary>
       ///是否有需求，每天更新
       /// </summary>
       [Display(Name ="是否有需求，每天更新")]
       [MaxLength(2)]
       [Column(TypeName="nvarchar(2)")]
       [Editable(true)]
       public string is_material { get; set; }

       /// <summary>
       ///父项工位信息,定时任务，每天晚上更新
       /// </summary>
       [Display(Name ="父项工位信息,定时任务，每天晚上更新")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string parent_wc_code { get; set; }

       /// <summary>
       ///父项工位信息
       /// </summary>
       [Display(Name ="父项工位信息")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string parent_wc_name { get; set; }

       /// <summary>
       ///更改的考核部门，aps手工录入
       /// </summary>
       [Display(Name ="更改的考核部门，aps手工录入")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string wc_code3 { get; set; }

       /// <summary>
       ///铆作工时
       /// </summary>
       [Display(Name ="铆作工时")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? op_mz_hours { get; set; }

       /// <summary>
       ///焊接工时
       /// </summary>
       [Display(Name ="焊接工时")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? op_hj_hours { get; set; }

       /// <summary>
       ///清理工时
       /// </summary>
       [Display(Name ="清理工时")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? op_ql_hours { get; set; }

       /// <summary>
       ///打压工时
       /// </summary>
       [Display(Name ="打压工时")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? op_dy_hours { get; set; }

       /// <summary>
       ///下序开工日期
       /// </summary>
       [Display(Name ="下序开工日期")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string next_start { get; set; }

       /// <summary>
       ///抽检数量
       /// </summary>
       [Display(Name ="抽检数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? check_quality_qty { get; set; }

       /// <summary>
       ///改件人员,强传标记
       /// </summary>
       [Display(Name ="改件人员,强传标记")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string gz_people { get; set; }

       /// <summary>
       ///下序工序号
       /// </summary>
       [Display(Name ="下序工序号")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string next_op { get; set; }

       /// <summary>
       ///优先度
       /// </summary>
       [Display(Name ="优先度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? aps_pri { get; set; }

       /// <summary>
       ///涂装入库标记
       /// </summary>
       [Display(Name ="涂装入库标记")]
       [MaxLength(2)]
       [Column(TypeName="nvarchar(2)")]
       [Editable(true)]
       public string inware_flag { get; set; }

       /// <summary>
       ///价值
       /// </summary>
       [Display(Name ="价值")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? item_amt { get; set; }

       /// <summary>
       ///外协需求日期
       /// </summary>
       [Display(Name ="外协需求日期")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string coop_demand_date { get; set; }

       /// <summary>
       ///外协父项
       /// </summary>
       [Display(Name ="外协父项")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       public string coop_parent_order { get; set; }

       /// <summary>
       ///外协返回工位
       /// </summary>
       [Display(Name ="外协返回工位")]
       [MaxLength(8)]
       [Column(TypeName="nvarchar(8)")]
       [Editable(true)]
       public string coop_parent_wc_code { get; set; }

       /// <summary>
       ///上序部门
       /// </summary>
       [Display(Name ="上序部门")]
       [MaxLength(8)]
       [Column(TypeName="nvarchar(8)")]
       [Editable(true)]
       public string rs_char4 { get; set; }

       /// <summary>
       ///上序工作中心编码
       /// </summary>
       [Display(Name ="上序工作中心编码")]
       [MaxLength(8)]
       [Column(TypeName="nvarchar(8)")]
       [Editable(true)]
       public string rs_char5 { get; set; }

       /// <summary>
       ///上序工作中心名称
       /// </summary>
       [Display(Name ="上序工作中心名称")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string rs_char5_name { get; set; }

       /// <summary>
       ///外协任务子项状态
       /// </summary>
       [Display(Name ="外协任务子项状态")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string child_status { get; set; }

       /// <summary>
       ///机加出工段工序前未完工序
       /// </summary>
       [Display(Name ="机加出工段工序前未完工序")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string unfinished_op { get; set; }

       /// <summary>
       ///下序工序状态
       /// </summary>
       [Display(Name ="下序工序状态")]
       [MaxLength(5)]
       [Column(TypeName="nvarchar(5)")]
       [Editable(true)]
       public string next_status { get; set; }

       /// <summary>
       ///加权价值
       /// </summary>
       [Display(Name ="加权价值")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? weight_item_amt { get; set; }

       /// <summary>
       ///加权价值标识，月末锁定后会添加此标识
       /// </summary>
       [Display(Name ="加权价值标识，月末锁定后会添加此标识")]
       [MaxLength(2)]
       [Column(TypeName="nvarchar(2)")]
       [Editable(true)]
       public string weight_mark { get; set; }

       /// <summary>
       ///下序工作中心后
       /// </summary>
       [Display(Name ="下序工作中心后")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string next_wc_code { get; set; }

       /// <summary>
       ///派送位置
       /// </summary>
       [Display(Name ="派送位置")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string position { get; set; }

       /// <summary>
       ///涂装父项首次记账时间
       /// </summary>
       [Display(Name ="涂装父项首次记账时间")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string father_clode_date { get; set; }

       /// <summary>
       ///是否已排产
       /// </summary>
       [Display(Name ="是否已排产")]
       [MaxLength(4000)]
       [Column(TypeName="varchar(4000)")]
       [Editable(true)]
       public string IsProduct { get; set; }

       
    }
}