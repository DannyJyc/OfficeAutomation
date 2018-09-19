using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("view_classtime_all")]
    public partial class view_classtime_all
    {
        #region 默认值
        public view_classtime_all()
        {
            id = 0;
            basedataid = 0;
            week = 0;
            lesson = 0;
            classroom = "";
            collegeid = 0;
            coursesid = 0;
            college_name = "";
            classes_name = "";
            courses_name = "";
            startweek = 0;
            endweek = 0;
            teachersid = 0;
            teachers_name = "";
            subclasses_name = "";
            classesid = 0;
            subclassesid = 0;
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
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
        /// 教室
        /// </summary>
        public string classroom { get; set; }
        /// <summary>
        /// 学院（校区）
        /// </summary>
        public int? collegeid { get; set; }
        /// <summary>
        /// 课程-讲师
        /// </summary>
        public int? coursesid { get; set; }
        /// <summary>
        /// 学院名称
        /// </summary>
        public string college_name { get; set; }
        /// <summary>
        /// 班级名称
        /// </summary>
        public string classes_name { get; set; }
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
        /// 班级名称
        /// </summary>
        public string subclasses_name { get; set; }
        /// <summary>
        /// 专业id
        /// </summary>
        public int? classesid { get; set; }
        /// <summary>
        /// 班级名称
        /// </summary>
        public int? subclassesid { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}