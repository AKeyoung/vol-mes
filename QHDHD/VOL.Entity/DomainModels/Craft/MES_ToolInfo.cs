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
    [Entity(TableCnName = "刀具管理",TableName = "MES_ToolInfo")]
    public partial class MES_ToolInfo:BaseEntity
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
       ///刀位号
       /// </summary>
       [Display(Name ="刀位号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string KnifePositionNumber { get; set; }

       /// <summary>
       ///刀位性质
       /// </summary>
       [Display(Name ="刀位性质")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string KnifePositionNature { get; set; }

       /// <summary>
       ///刀型编号
       /// </summary>
       [Display(Name ="刀型编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string KnifeTypeNumber { get; set; }

       /// <summary>
       ///刀具编号
       /// </summary>
       [Display(Name ="刀具编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ToolNumber { get; set; }

       /// <summary>
       ///刀具类别
       /// </summary>
       [Display(Name ="刀具类别")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ToolCategory { get; set; }

       /// <summary>
       ///刀具规格
       /// </summary>
       [Display(Name ="刀具规格")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ToolSpecification { get; set; }

       /// <summary>
       ///刀柄规格
       /// </summary>
       [Display(Name ="刀柄规格")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string HandleSpecification { get; set; }

       /// <summary>
       ///装夹长度
       /// </summary>
       [Display(Name ="装夹长度")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ClampingLength { get; set; }

       /// <summary>
       ///加工材质
       /// </summary>
       [Display(Name ="加工材质")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ProcessingMaterial { get; set; }

       /// <summary>
       ///使用功能
       /// </summary>
       [Display(Name ="使用功能")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string UsageFunction { get; set; }

       /// <summary>
       ///刀补号H
       /// </summary>
       [Display(Name ="刀补号H")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ToolCompensationH { get; set; }

       /// <summary>
       ///刀补号D
       /// </summary>
       [Display(Name ="刀补号D")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ToolCompensationD { get; set; }

       /// <summary>
       ///监控方式
       /// </summary>
       [Display(Name ="监控方式")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string MonitoringMethod { get; set; }

       /// <summary>
       ///更换方式
       /// </summary>
       [Display(Name ="更换方式")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ReplacementMethod { get; set; }

       /// <summary>
       ///设定值
       /// </summary>
       [Display(Name ="设定值")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SettingValue { get; set; }

       /// <summary>
       ///实际值
       /// </summary>
       [Display(Name ="实际值")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ActualValue { get; set; }

       /// <summary>
       ///对刀要求
       /// </summary>
       [Display(Name ="对刀要求")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ToolSettingRequirements { get; set; }

       /// <summary>
       ///刀具状态
       /// </summary>
       [Display(Name ="刀具状态")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ToolStatus { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateTime { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? UpdateTime { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string CreateUser { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string UpdateUser { get; set; }

       
    }
}