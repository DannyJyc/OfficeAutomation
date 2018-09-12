using System;
using System.Collections.Generic;
using System.Text;
using Chloe.Annotations;

namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("view_users_college")]
    public partial class view_users_college
    {
        #region 默认值
        public view_users_college()
        {

            name = "";
            collegeid = 0;
            username = "";
            password = "";
            dicvalue = "";
            reserve1 = "";
            reserve2 = "";
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 学院id
        /// </summary>
        public int collegeid { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 状态1可用
        /// </summary>
        public int state { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public string dicvalue { get; set; }
        /// <summary>
        /// 备用1
        /// </summary>
        public string reserve1 { get; set; }
        /// <summary>
        /// 备用2
        /// </summary>
        public string reserve2 { get; set; }
        /// <summary>
        /// 学院
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
