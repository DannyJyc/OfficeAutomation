using Chloe.Annotations;

namespace OfficeAutomation.Models
{
    public partial class college
    {
        public college()
        {
            name = "";
        }
        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        /// <summary>
        /// 学院名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
    }
}
