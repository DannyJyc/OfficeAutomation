using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("view_data_all_group")]
    public partial class view_data_all_group
    {
        #region 默认值
        public view_data_all_group()
        {
            collegeid = 0;
            classesid = 0;
            classes_name = "";
        }
        #endregion

        #region Model
        /// <summary>
        /// 学院（校区）
        /// </summary>
        public int? collegeid { get; set; }
        /// <summary>
        /// 专业名称
        /// </summary>
        public int? classesid { get; set; }
        /// <summary>
        /// 班级名称
        /// </summary>
        public string classes_name { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}