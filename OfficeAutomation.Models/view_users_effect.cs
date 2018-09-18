using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("view_users_effect")]
    public partial class view_users_effect
    {
        #region 默认值
        public view_users_effect()
        {
            name = "";
            controller = "";
            id = 0;
        }
        #endregion

        #region Model
        /// <summary>
        /// 功能名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 对应控制器
        /// </summary>
        public string controller { get; set; }
        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}