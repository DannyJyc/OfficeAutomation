﻿using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("users")]
    public partial class users
    {
        #region 默认值
        public users()
        {

            name = "";
            collegeid = 0;
            username = "";
            password = "";
            state = 0;
            control = 0;
            dicvalue = "";
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
        /// 姓名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 学院id
        /// </summary>
        public int? collegeid { get; set; }
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
        public int? state { get; set; }
        /// <summary>
        /// 允许控制下级
        /// </summary>
        public int? control { get; set; }
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
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}