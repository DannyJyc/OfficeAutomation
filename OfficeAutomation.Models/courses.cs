using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("courses")]
    public partial class courses
    {
        #region 默认值
        public courses()
        {

            name = "";
            startweek = 0;
            endweek = 0;
            teachersid = 0;
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        /// <summary>
        /// 课程名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 开始周
        /// </summary>
        public int? startweek { get; set; }
        /// <summary>
        /// 结束周
        /// </summary>
        public int? endweek { get; set; }
        /// <summary>
        /// 讲师
        /// </summary>
        public int? teachersid { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}