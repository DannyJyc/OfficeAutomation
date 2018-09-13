﻿using log4net;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.BLL
{
    public class BLL_Teachers
    {
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));
        private DAL.DAL_Teachers dalTeachers = new DAL_Teachers();
        BaseResult result = new BaseResult();
        /// <summary>
        /// 返回数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public BaseResult List(int page, int limit)
        {
            result.code = 0;
            result.count = dalTeachers.List().Count;
            result.data = dalTeachers.List(page, limit);
            return result;
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="effect"></param>
        /// <returns></returns>
        public BaseResult Update(teachers teachers)
        {
            result.code = 0;
            if (teachers.id != 0)
            {
                if (dalTeachers.Update(teachers) == 0)
                {
                    result.code = -1;
                    result.msg = "修改失败";
                }
                else { }
            }
            else
            {
                if (dalTeachers.Add(teachers) == 0)
                {
                    result.code = -1;
                    result.msg = "添加失败";
                }
                else { }
            }

            return result;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BaseResult Del(int id)
        {
            result.code = 0;
            if (dalTeachers.Del(id) == 0)
            {
                result.code = -1;
                result.msg = "删除失败，找不到对应教师";
            }
            else { }

            return result;
        }
    }
}
