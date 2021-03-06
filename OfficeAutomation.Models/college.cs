﻿using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("college")]
    public partial class college
    {
        #region 默认值
        public college()
        {

            name = "";
            buid = 0;
        }
        #endregion

        #region Model
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
        /// 所属事业部
        /// </summary>
        public int? buid { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}