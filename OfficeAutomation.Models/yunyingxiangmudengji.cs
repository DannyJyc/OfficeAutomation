using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("yunyingxiangmudengji")]
    public partial class yunyingxiangmudengji
    {
        #region 默认值
        public yunyingxiangmudengji()
        {

            number = "";
            yunyingmingcheng = "";
            jiancheng = "";
            yifang = "";
            jianchngyi = "";
            yunyingchanquan = "";
            addtime = System.DateTime.Now;
            endtime = System.DateTime.Now;
            s_province = "";
            s_city = "";
            s_county = "";
            address = "";
            didian = "";
            lou = "";
            fangjianhao = "";
            didiancanquan = "";
            didianendetime = System.DateTime.Now;
            lianxirenjia = "";
            phonejia = "";
            teljia = "";
            emailjia = "";
            lianxirenyi = "";
            phoneyi = "";
            telyi = "";
            emailyi = "";
            state = 0;
            zhuzhijiagoumingcheng = "";
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        /// <summary>
        /// 协议编号
        /// </summary>
        public string number { get; set; }
        /// <summary>
        /// 运营项目名称(甲)
        /// </summary>
        public string yunyingmingcheng { get; set; }
        /// <summary>
        /// 运营项目简称(甲)
        /// </summary>
        public string jiancheng { get; set; }
        /// <summary>
        /// 运营项目名称(乙)
        /// </summary>
        public string yifang { get; set; }
        /// <summary>
        /// 运营项目简称(乙)
        /// </summary>
        public string jianchngyi { get; set; }
        /// <summary>
        /// 运营项目产权
        /// </summary>
        public string yunyingchanquan { get; set; }
        /// <summary>
        /// 运营起始时间
        /// </summary>
        public DateTime? addtime { get; set; }
        /// <summary>
        /// 终止时间
        /// </summary>
        public DateTime? endtime { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        public string s_province { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        public string s_city { get; set; }
        /// <summary>
        /// 区
        /// </summary>
        public string s_county { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 地点名称
        /// </summary>
        public string didian { get; set; }
        /// <summary>
        /// 楼宇名称
        /// </summary>
        public string lou { get; set; }
        /// <summary>
        /// 楼层&房间号
        /// </summary>
        public string fangjianhao { get; set; }
        /// <summary>
        /// 运营地点产权
        /// </summary>
        public string didiancanquan { get; set; }
        /// <summary>
        /// 运营地点期限
        /// </summary>
        public DateTime? didianendetime { get; set; }
        /// <summary>
        /// 甲方联系人
        /// </summary>
        public string lianxirenjia { get; set; }
        /// <summary>
        /// 甲方联系电话
        /// </summary>
        public string phonejia { get; set; }
        /// <summary>
        /// 甲方固定电话
        /// </summary>
        public string teljia { get; set; }
        /// <summary>
        /// 甲方邮箱
        /// </summary>
        public string emailjia { get; set; }
        /// <summary>
        /// 乙方联系人
        /// </summary>
        public string lianxirenyi { get; set; }
        /// <summary>
        /// 乙方联系电话
        /// </summary>
        public string phoneyi { get; set; }
        /// <summary>
        /// 乙方固定电话
        /// </summary>
        public string telyi { get; set; }
        /// <summary>
        /// 乙方邮箱
        /// </summary>
        public string emailyi { get; set; }
        /// <summary>
        /// 审核状态 0未通过 1通过 2审核中
        /// </summary>
        public int? state { get; set; }
        /// <summary>
        /// 组织架构名称
        /// </summary>
        public string zhuzhijiagoumingcheng { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}