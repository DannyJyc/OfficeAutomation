using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("view_teachers_college")]
    public partial class view_teachers_college
    {
        #region 默认值
        public view_teachers_college()
        {
            id = 0;
            name = "";
            collegeid = 0;
            college_id = 0;
            college_name = "";
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 老师名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 所属学院
        /// </summary>
        public int? collegeid { get; set; }
        /// <summary>
        /// college_id
        /// </summary>
        public int college_id { get; set; }
        /// <summary>
        /// 学院名称
        /// </summary>
        public string college_name { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}