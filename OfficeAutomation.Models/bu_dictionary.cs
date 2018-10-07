using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("bu_dictionary")]
    public partial class bu_dictionary
    {
        #region 默认值
        public bu_dictionary()
        {

            type = "";
            remark = "";
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        /// <summary>
        /// 事业部类型
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}