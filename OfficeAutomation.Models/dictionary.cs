using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("dictionary")]
    public partial class dictionary
    {
        #region 默认值
        public dictionary()
        {

            key = "";
            value = "";
            reserve1 = "";
            reserve2 = "";
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        /// <summary>
        /// 键
        /// </summary>
        public string key { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// 备用1
        /// </summary>
        public string reserve1 { get; set; }
        /// <summary>
        /// 备用2
        /// </summary>
        public string reserve2 { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}