using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.BLL
{
    public class BLL_Classtime_All
    {
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));
        private DAL.DAL_Classtime_All dalClasstimeAll = new DAL_Classtime_All();
        private DAL.DAL_Basedata dalBasedata = new DAL_Basedata();
        private DAL.DAL_Courses dalCourses = new DAL_Courses();
        BaseResult result = new BaseResult();
        /// <summary>
        /// 所有数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public BaseResult List(users users,int page, int limit)
        {
            if (users.dicvalue == "0")
            {
                result.code = 0;
                result.count = dalClasstimeAll.List().Count;
                result.data = dalClasstimeAll.List(page, limit);
                return result;
            }
            result.code = 0;
            result.count = dalClasstimeAll.List(users.collegeid).Count;
            result.data = dalClasstimeAll.List(users.collegeid,page, limit);
            return result;
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="users"></param>
        /// <param name="classtime"></param>
        /// <returns></returns>
        public BaseResult Update(users users,view_classtime_all classtime)
        {
            classtime classtimeTemp = new classtime();
            result.code = 0;
            if (classtime.week == 0||classtime.week==null)
            {
                result.code = -2;
                result.msg = "请选择星期";
                return result;
            }

            if (classtime.lesson == 0||classtime.lesson==null)
            {
                result.code = -2;
                result.msg = "请选择课节";
                return result;
            }
            if (users.collegeid != classtime.collegeid&&users.dicvalue!="0")
            {
                result.code = -2;
                result.msg = "您无权添加其他学院的课表信息！";
                return result;
            }

            if (dalCourses.Single(classtime.coursesid).collegeid != classtime.collegeid)
            {
                result.code = -2;
                result.msg = "该学院无此课程！请检查讲师所属学院！";
                return result;
            }

            int ishave = dalBasedata.IsHave(classtime.collegeid, classtime.classesid, classtime.coursesid);
            if (ishave == 0)
            {
                basedata basedata = new basedata();
                basedata.collegeid = classtime.collegeid;
                basedata.classesid = classtime.classesid;
                basedata.coursesid = classtime.coursesid;
                ishave = dalBasedata.Add(basedata);
            }

            classtimeTemp.basedataid = ishave;
            classtimeTemp.week = classtime.week;
            classtimeTemp.lesson = classtime.lesson;
            classtimeTemp.classroom = classtime.classroom;
            if (classtime.id == 0)
            {
                dalClasstimeAll.Add(classtimeTemp);
                return result;
            }
            else
            {

            }

            classtimeTemp.id = classtime.id;
            dalClasstimeAll.Update(classtimeTemp);
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
            if (dalClasstimeAll.Del(id) == 0)
            {
                result.code = -1;
                result.msg = "删除失败，找不到对应课程信息";
            }
            else { }

            return result;
        }
    }
}
