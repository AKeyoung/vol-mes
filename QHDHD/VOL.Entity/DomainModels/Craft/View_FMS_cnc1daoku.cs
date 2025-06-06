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
    [Entity(TableCnName = "刀具使用寿命",TableName = "View_FMS_cnc1daoku")]
    public partial class View_FMS_cnc1daoku:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int ID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DataSource")]
       [MaxLength(13)]
       [Column(TypeName="varchar(13)")]
       [Editable(true)]
       public string DataSource { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="RowId")]
       [MaxLength(43)]
       [Column(TypeName="nvarchar(43)")]
       [Required(AllowEmptyStrings=false)]
       public string RowId { get; set; }

       /// <summary>
       ///机器编号
       /// </summary>
       [Display(Name ="机器编号")]
       [Column(TypeName="int")]
       public int? RobotNo { get; set; }

       /// <summary>
       ///刀位号
       /// </summary>
       [Display(Name ="刀位号")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       public string KnifePositionNumber { get; set; }

       /// <summary>
       ///刀位性质
       /// </summary>
       [Display(Name ="刀位性质")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string KnifePositionNature { get; set; }

       /// <summary>
       ///刀型编号
       /// </summary>
       [Display(Name ="刀型编号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string KnifeTypeNumber { get; set; }

       /// <summary>
       ///刀具编号
       /// </summary>
       [Display(Name ="刀具编号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ToolNumber { get; set; }

       /// <summary>
       ///刀具类别
       /// </summary>
       [Display(Name ="刀具类别")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ToolCategory { get; set; }

       /// <summary>
       ///刀具规格
       /// </summary>
       [Display(Name ="刀具规格")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ToolSpecification { get; set; }

       /// <summary>
       ///刀柄规格
       /// </summary>
       [Display(Name ="刀柄规格")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string HandleSpecification { get; set; }

       /// <summary>
       ///装夹长度
       /// </summary>
       [Display(Name ="装夹长度")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ClampingLength { get; set; }

       /// <summary>
       ///加工材质
       /// </summary>
       [Display(Name ="加工材质")]
       [MaxLength(32)]
       [Column(TypeName="nvarchar(32)")]
       public string ProcessingMaterial { get; set; }

       /// <summary>
       ///使用功能
       /// </summary>
       [Display(Name ="使用功能")]
       [MaxLength(32)]
       [Column(TypeName="nvarchar(32)")]
       public string UsageFunction { get; set; }

       /// <summary>
       ///刀补号H
       /// </summary>
       [Display(Name ="刀补号H")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ToolCompensationH { get; set; }

       /// <summary>
       ///刀补号D
       /// </summary>
       [Display(Name ="刀补号D")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ToolCompensationD { get; set; }

       /// <summary>
       ///监控方式
       /// </summary>
       [Display(Name ="监控方式")]
       [MaxLength(32)]
       [Column(TypeName="nvarchar(32)")]
       public string MonitoringMethod { get; set; }

       /// <summary>
       ///更换方式
       /// </summary>
       [Display(Name ="更换方式")]
       [MaxLength(32)]
       [Column(TypeName="nvarchar(32)")]
       public string ReplacementMethod { get; set; }

       /// <summary>
       ///设定值
       /// </summary>
       [Display(Name ="设定值")]
       [MaxLength(32)]
       [Column(TypeName="nvarchar(32)")]
       public string SettingValue { get; set; }

       /// <summary>
       ///实际值
       /// </summary>
       [Display(Name ="实际值")]
       [MaxLength(32)]
       [Column(TypeName="nvarchar(32)")]
       public string ActualValue { get; set; }

       /// <summary>
       ///剩余值
       /// </summary>
       [Display(Name ="剩余值")]
       [MaxLength(30)]
       [Column(TypeName="varchar(30)")]
       public string ResidualValue { get; set; }

       /// <summary>
       ///负载值
       /// </summary>
       [Display(Name ="负载值")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string LoadValue { get; set; }

       /// <summary>
       ///对刀要求
       /// </summary>
       [Display(Name ="对刀要求")]
       [MaxLength(32)]
       [Column(TypeName="nvarchar(32)")]
       public string ToolSettingRequirements { get; set; }

       /// <summary>
       ///刀具状态
       /// </summary>
       [Display(Name ="刀具状态")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ToolStatus { get; set; }

       /// <summary>
       ///仓位状态
       /// </summary>
       [Display(Name ="仓位状态")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string PositionStatus { get; set; }

       
    }
}