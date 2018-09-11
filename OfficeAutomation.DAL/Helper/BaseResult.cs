using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeAutomation.DAL.Helper
{
    public class BaseResult
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string msg { get; set; }

        /// <summary>
        /// 数据长度
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// 数据/数据集
        /// </summary>
        public object data { get; set; }

        /// <summary>
        /// 唯一标识
        /// </summary>
        public string token { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public double remark { get; set; }
        /// <summary>
        /// 初始化数据
        /// </summary>
        public static BaseResult Fail()
        {
            BaseResult baseResult = new BaseResult
            {
                code = 9999,
                count = 0,
                msg = "未知错误",
                data = null,
                token = null,
                remark = 0
            };
            return baseResult;
        }
    }
}
