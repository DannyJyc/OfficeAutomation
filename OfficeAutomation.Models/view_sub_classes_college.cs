using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("view_sub_classes_college")]
    public partial class view_sub_classes_college
    {
        #region 默认值
        public view_sub_classes_college()
        {
            id = 0;
            classesid = 0;
            name = "";
            classes_name = "";
            college_name = "";
            college_id = 0;
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 专业id
        /// </summary>
        public int? classesid { get; set; }
        /// <summary>
        /// 班级名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 班级名称
        /// </summary>
        public string classes_name { get; set; }
        /// <summary>
        /// 学院名称
        /// </summary>
        public string college_name { get; set; }
        /// <summary>
        /// college_id
        /// </summary>
        public int college_id { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}