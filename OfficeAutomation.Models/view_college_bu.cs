using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("view_college_bu")]
    public partial class view_college_bu
    {
        #region 默认值
        public view_college_bu()
        {
            id = 0;
            name = "";
            buid = 0;
            type = "";
            remark = "";
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 学院名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 所属事业部
        /// </summary>
        public int? buid { get; set; }
        /// <summary>
        /// 事业部类型
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}