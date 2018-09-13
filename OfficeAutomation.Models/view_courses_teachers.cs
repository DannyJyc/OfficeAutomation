using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("view_courses_teachers")]
    public partial class view_courses_teachers
    {
        #region 默认值
        public view_courses_teachers()
        {
            id = 0;
            name = "";
            startweek = 0;
            endweek = 0;
            teachers_name = "";
            collegeid = 0;
            teachers_id = 0;
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
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
        /// 老师名称
        /// </summary>
        public string teachers_name { get; set; }
        /// <summary>
        /// 所属学院
        /// </summary>
        public int? collegeid { get; set; }
        /// <summary>
        /// teachers_id
        /// </summary>
        public int teachers_id { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}