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
    [Entity(TableCnName = "生产工单明细",TableName = "MES_WorkpieceInfoDetail")]
    public partial class MES_WorkpieceInfoDetail:BaseEntity
    {
        /// <summary>
       ///主键，自增
       /// </summary>
       [Key]
       [Display(Name ="主键，自增")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///刀号
       /// </summary>
       [Display(Name ="刀号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ToolNumber { get; set; }

       /// <summary>
       ///刀型编号
       /// </summary>
       [Display(Name ="刀型编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ToolTypeNumber { get; set; }

       /// <summary>
       ///刀具直径
       /// </summary>
       [Display(Name ="刀具直径")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? ToolDiameter { get; set; }

       /// <summary>
       ///装刀长度
       /// </summary>
       [Display(Name ="装刀长度")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? ToolInstallationLength { get; set; }

       /// <summary>
       ///转速
       /// </summary>
       [Display(Name ="转速")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? RotationalSpeed { get; set; }

       /// <summary>
       ///进给
       /// </summary>
       [Display(Name ="进给")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? FeedRate { get; set; }

       /// <summary>
       ///余量
       /// </summary>
       [Display(Name ="余量")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? Allowance { get; set; }

       /// <summary>
       ///刀补号
       /// </summary>
       [Display(Name ="刀补号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ToolCompensationNumber { get; set; }

       /// <summary>
       ///时间
       /// </summary>
       [Display(Name ="时间")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? ProcessingTime { get; set; }

       /// <summary>
       ///Z深
       /// </summary>
       [Display(Name ="Z深")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? ZDepth { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string Remarks { get; set; }

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

       /// <summary>
       ///主表 ID
       /// </summary>
       [Display(Name ="主表 ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? WIID { get; set; }

       
    }
}