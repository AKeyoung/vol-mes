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
    [Entity(TableCnName = "工艺信息",TableName = "MES_Craft")]
    public partial class MES_Craft:BaseEntity
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
       ///工艺名称
       /// </summary>
       [Display(Name ="工艺名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Name { get; set; }

       /// <summary>
       ///排序标志
       /// </summary>
       [Display(Name ="排序标志")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int OrderIndex { get; set; }

       /// <summary>
       ///工艺内容
       /// </summary>
       [Display(Name ="工艺内容")]
       [MaxLength(1000)]
       [Column(TypeName="varchar(1000)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Content { get; set; }

       /// <summary>
       ///技术要求
       /// </summary>
       [Display(Name ="技术要求")]
       [MaxLength(1000)]
       [Column(TypeName="varchar(1000)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Require { get; set; }

       /// <summary>
       ///指导文件
       /// </summary>
       [Display(Name ="指导文件")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string GuidanceFile { get; set; }

       /// <summary>
       ///是否启用
       /// </summary>
       [Display(Name ="是否启用")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Enable { get; set; }

       /// <summary>
       ///工位ID
       /// </summary>
       [Display(Name ="工位ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? WorkStaitionId { get; set; }

       /// <summary>
       ///更新人
       /// </summary>
       [Display(Name ="更新人")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string UpdateUser { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
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