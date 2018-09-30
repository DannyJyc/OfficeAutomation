using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("threelevel")]
    public partial class threelevel
    {
        #region 默认值
        public threelevel()
        {

            name = "";
            definition = "";
            according = "";
            origin = "";
            state = 0;
            two_id = 0;
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        /// <summary>
        /// 三级科目名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 定义
        /// </summary>
        public string definition { get; set; }
        /// <summary>
        /// 依据
        /// </summary>
        public string according { get; set; }
        /// <summary>
        /// 来源
        /// </summary>
        public string origin { get; set; }
        /// <summary>
        /// 状态1正常 0关闭
        /// </summary>
        public int? state { get; set; }
        /// <summary>
        /// 二级ID
        /// </summary>
        public int? two_id { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}