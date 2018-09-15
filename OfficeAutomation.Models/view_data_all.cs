using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("view_data_all")]
    public partial class view_data_all
    {
        #region 默认值
        public view_data_all()
        {
            id = 0;
            collegeid = 0;
            classesid = 0;
            coursesid = 0;
            classroom = "";
            classes_name = "";
            college_name = "";
            courses_name = "";
            startweek = 0;
            endweek = 0;
            teachersid = 0;
            teachers_name = "";
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
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
        /// 班级名称
        /// </summary>
        public string classes_name { get; set; }
        /// <summary>
        /// 学院名称
        /// </summary>
        public string college_name { get; set; }
        /// <summary>
        /// 课程名称
        /// </summary>
        public string courses_name { get; set; }
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
        /// 老师名称
        /// </summary>
        public string teachers_name { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}