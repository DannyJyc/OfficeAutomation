using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("twolevel")]
    public partial class twolevel
    {
        #region 默认值
        public twolevel()
        {

            name = "";
            one_id = 0;
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
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
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}