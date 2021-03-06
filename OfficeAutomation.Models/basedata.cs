﻿using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("basedata")]
    public partial class basedata
    {
        #region 默认值
        public basedata()
        {

            collegeid = 0;
            subclassesid = 0;
            coursesid = 0;
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        /// <summary>
        /// 学院（校区）
        /// </summary>
        public int? collegeid { get; set; }
        /// <summary>
        /// 班级名称
        /// </summary>
        public int? subclassesid { get; set; }
        /// <summary>
        /// 课程-讲师
        /// </summary>
        public int? coursesid { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}