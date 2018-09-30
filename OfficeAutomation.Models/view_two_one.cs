using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("view_two_one")]
    public partial class view_two_one
    {
        #region 默认值
        public view_two_one()
        {
            id = 0;
            name = "";
            one_id = 0;
            one_name = "";
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 二级科目名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 一级ID
        /// </summary>
        public int? one_id { get; set; }
        /// <summary>
        /// 一级科目名称
        /// </summary>
        public string one_name { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}