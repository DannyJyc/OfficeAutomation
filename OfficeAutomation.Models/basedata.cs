using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("basedata")]
    public partial class basedata
    {
        #region 默认值
        public basedata()
        {

            collegeid = 0;
            classesid = 0;
            coursesid = 0;
            classroom = "";
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        /// <summary>
        /// 学院（校区）
        /// </summary>
        public int? collegeid { get; set; }
        /// <summary>
        /// 专业名称
        /// </summary>
        public int? classesid { get; set; }
        /// <summary>
        /// 课程-讲师
        /// </summary>
        public int? coursesid { get; set; }
        /// <summary>
        /// 教室
        /// </summary>
        public string classroom { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}