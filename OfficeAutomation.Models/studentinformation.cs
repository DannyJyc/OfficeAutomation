using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("studentinformation")]
    public partial class studentinformation
    {
        #region 默认值
        public studentinformation()
        {

            title = "";
            number = 0;
            years = "";
            xiaoqu = "";
            zhuanye = "";
            name = "";
            jinengfangxiang = "";
            idcard = "";
            sex = "";
            qidian = "";
            birthday = "";
            minzu = "";
            phone = "";
            tel = "";
            addtime = System.DateTime.Now;
            f_name = "";
            f_tel = "";
            m_name = "";
            m_tel = "";
            sheng = "";
            shi = "";
            qu = "";
            chengci = "";
            biye = "";
            xueli = "";
            xuejinumber = "";
            nianji = "";
            yuanxiao = "";
            state = "";
            zixun = "";
            qudao = "";
            ruxuefangshi = "";
            tijaoren = "";
            updatetime = System.DateTime.Now;
            statusmajor = "";
            educationallevel = "";
            politicalstatus = "";
            registered = "";
            statusquarter = "";
            speciality = "";
            majorlevel = "";
            schoolsystem = "";
            hundredThousand = 0;
            allowances = 0;
            income = "";
            postalcode = "";
            learntype = "";
            quarter = "";
            classes = "";
            bankid = 0;
            yearsincome = "";
            difficulty = 0;
            teachers = "";
            wechat = "";
            qq = "";
            urgentphone = "";
            office = "";
            code = 0;
            baseuse = 0;
            intern = 0;
            learned = "";
            other = "";
            gocity = "";
            learnroad = "";
            moneytype = "";
            coursesnumber = 0;
            coursesdays = 0;
            nextmoney = "";
            reminddate = System.DateTime.Now;
            teacherid = "";
            channelid = "";
            internperson = "";
            internpersonid = "";
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 档案编号
        /// </summary>
        public int? number { get; set; }
        /// <summary>
        /// 年级
        /// </summary>
        public string years { get; set; }
        /// <summary>
        /// 校区
        /// </summary>
        public string xiaoqu { get; set; }
        /// <summary>
        /// 专业
        /// </summary>
        public string zhuanye { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 技能方向
        /// </summary>
        public string jinengfangxiang { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string idcard { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string sex { get; set; }
        /// <summary>
        /// 升学起点
        /// </summary>
        public string qidian { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public string birthday { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        public string minzu { get; set; }
        /// <summary>
        /// 移动电话
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 固定电话
        /// </summary>
        public string tel { get; set; }
        /// <summary>
        /// 填表时间
        /// </summary>
        public DateTime? addtime { get; set; }
        /// <summary>
        /// 父亲姓名
        /// </summary>
        public string f_name { get; set; }
        /// <summary>
        /// 父亲电话
        /// </summary>
        public string f_tel { get; set; }
        /// <summary>
        /// 母亲姓名
        /// </summary>
        public string m_name { get; set; }
        /// <summary>
        /// 母亲电话
        /// </summary>
        public string m_tel { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        public string sheng { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        public string shi { get; set; }
        /// <summary>
        /// 区
        /// </summary>
        public string qu { get; set; }
        /// <summary>
        /// 学校层次
        /// </summary>
        public string chengci { get; set; }
        /// <summary>
        /// 毕业学校
        /// </summary>
        public string biye { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        public string xueli { get; set; }
        /// <summary>
        /// 学籍号
        /// </summary>
        public string xuejinumber { get; set; }
        /// <summary>
        /// 学籍年级
        /// </summary>
        public string nianji { get; set; }
        /// <summary>
        /// 学院院校
        /// </summary>
        public string yuanxiao { get; set; }
        /// <summary>
        /// 学籍状态
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// 咨询师
        /// </summary>
        public string zixun { get; set; }
        /// <summary>
        /// 渠道人员
        /// </summary>
        public string qudao { get; set; }
        /// <summary>
        /// 入学方式
        /// </summary>
        public string ruxuefangshi { get; set; }
        /// <summary>
        /// 提交人
        /// </summary>
        public string tijaoren { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? updatetime { get; set; }
        /// <summary>
        /// 学籍专业
        /// </summary>
        public string statusmajor { get; set; }
        /// <summary>
        /// 学历层次
        /// </summary>
        public string educationallevel { get; set; }
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string politicalstatus { get; set; }
        /// <summary>
        /// 户口性质
        /// </summary>
        public string registered { get; set; }
        /// <summary>
        /// 学籍季度
        /// </summary>
        public string statusquarter { get; set; }
        /// <summary>
        /// 特长、爱好
        /// </summary>
        public string speciality { get; set; }
        /// <summary>
        /// 专业级别
        /// </summary>
        public string majorlevel { get; set; }
        /// <summary>
        /// 学制
        /// </summary>
        public string schoolsystem { get; set; }
        /// <summary>
        /// 时候10w一下民族
        /// </summary>
        public int? hundredThousand { get; set; }
        /// <summary>
        /// 是否低保
        /// </summary>
        public int? allowances { get; set; }
        /// <summary>
        /// 收入来源
        /// </summary>
        public string income { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string postalcode { get; set; }
        /// <summary>
        /// 学习形式
        /// </summary>
        public string learntype { get; set; }
        /// <summary>
        /// 招生季度
        /// </summary>
        public string quarter { get; set; }
        /// <summary>
        /// 班级
        /// </summary>
        public string classes { get; set; }
        /// <summary>
        /// 银行卡号
        /// </summary>
        public int? bankid { get; set; }
        /// <summary>
        /// 家庭年收入
        /// </summary>
        public string yearsincome { get; set; }
        /// <summary>
        /// 是否家庭困难
        /// </summary>
        public int? difficulty { get; set; }
        /// <summary>
        /// 班主任
        /// </summary>
        public string teachers { get; set; }
        /// <summary>
        /// 微信号
        /// </summary>
        public string wechat { get; set; }
        /// <summary>
        /// QQ号
        /// </summary>
        public string qq { get; set; }
        /// <summary>
        /// 紧急电话
        /// </summary>
        public string urgentphone { get; set; }
        /// <summary>
        /// office使用情况
        /// </summary>
        public string office { get; set; }
        /// <summary>
        /// 是否软件编程
        /// </summary>
        public int? code { get; set; }
        /// <summary>
        /// 是否tcp/ip/windows使用
        /// </summary>
        public int? baseuse { get; set; }
        /// <summary>
        /// 是否上网
        /// </summary>
        public int? intern { get; set; }
        /// <summary>
        /// 学习过的相关课程
        /// </summary>
        public string learned { get; set; }
        /// <summary>
        /// 其他说明
        /// </summary>
        public string other { get; set; }
        /// <summary>
        /// 意向就业城市
        /// </summary>
        public string gocity { get; set; }
        /// <summary>
        /// 学习方向
        /// </summary>
        public string learnroad { get; set; }
        /// <summary>
        /// 交费类型
        /// </summary>
        public string moneytype { get; set; }
        /// <summary>
        /// 课程总学时
        /// </summary>
        public int? coursesnumber { get; set; }
        /// <summary>
        /// 课程总天数
        /// </summary>
        public int? coursesdays { get; set; }
        /// <summary>
        /// 下一次交费
        /// </summary>
        public string nextmoney { get; set; }
        /// <summary>
        /// 提醒时间
        /// </summary>
        public DateTime? reminddate { get; set; }
        /// <summary>
        /// 咨询师id
        /// </summary>
        public string teacherid { get; set; }
        /// <summary>
        /// 渠道id
        /// </summary>
        public string channelid { get; set; }
        /// <summary>
        /// 网资专员
        /// </summary>
        public string internperson { get; set; }
        /// <summary>
        /// 网资专员id
        /// </summary>
        public string internpersonid { get; set; }

        /// <summary>
        /// 非SQL映射字段 
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }
        #endregion
    }
}