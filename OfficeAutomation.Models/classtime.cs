using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("classtime")]
    public partial class classtime
    {
        #region 默认值
        public classtime()
        {

            basedataid = 0;
            week = 0;
            lesson = 0;
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        /// <summary>
        /// 基础数据
        /// </summary>
        public int? basedataid { get; set; }
        /// <summary>
        /// 周
        /// </summary>
        public int? week { get; set; }
        /// <summary>
        /// 课节
        /// </summary>
        public int? lesson { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}