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
        /// 获取课表
        /// </summary>
        /// <param name="collegeid"></param>
        /// <param name="classesid"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        public BaseResult GetAllClasstime(int teachersid,int collegeid,int classesid,int week)
        {
            List<Classtime> list = new List<Classtime>();
            for (int i = 1; i <= 5; i++)
            {
                Classtime classtime = new Classtime();

                switch (i)
                {
                    case 1:
                        classtime.Lesson = "第一节课(上午1、2)";
                        break;
                    case 2:
                        classtime.Lesson = "第二节课(上午3、4)";
                        break;
                    case 3:
                        classtime.Lesson = "第三节课(下午1、2)";
                        break;
                    case 4:
                        classtime.Lesson = "第四节课(下午3、4)";
                        break;
                    case 5:
                        classtime.Lesson = "第五节课(下午5、6)";
                        break;
                }
                list.Add(classtime);
            }
            if (teachersid==0&&collegeid == 0 && classesid == 0 && week == 0)
            {
                result.code = 0;
                result.data = list;
                return result;
            }

            for (var a = 1; a <= 5; a++)
            {
                for (var b = 1; b <= 7; b++)
                {
                    view_classtime_all temp;
                    if (teachersid == 0) { 
                        temp = dalClasstimeAll.ListByWhere(collegeid, classesid, week, b, a);
                    }
                    else
                    {
                        temp = dalClasstimeAll.ListByWhere(teachersid,b,a);
                    }
                    if (temp != null)
                    {
                        switch (b)
                        {
                            case 1:
                                list[a-1].Mon= temp.courses_name+temp.teachers_name+"("+temp.startweek+"-"+temp.endweek+")";
                                break;
                            case 2:
                                list[a-1].Tues= temp.courses_name + temp.teachers_name + "(" + temp.startweek + "-" + temp.endweek + ")";
                                break;
                            case 3:
                                list[a-1].Wednes= temp.courses_name + temp.teachers_name + "(" + temp.startweek + "-" + temp.endweek + ")";
                                break;
                            case 4:
                                list[a-1].Thurs= temp.courses_name + temp.teachers_name + "(" + temp.startweek + "-" + temp.endweek + ")";
                                break;
                            case 5:
                                list[a-1].Fri= temp.courses_name + temp.teachers_name + "(" + temp.startweek + "-" + temp.endweek + ")";
                                break;
                            case 6:
                                list[a-1].Sat= temp.courses_name + temp.teachers_name + "(" + temp.startweek + "-" + temp.endweek + ")";
                                break;
                            case 7:
                                list[a-1].Sun= temp.courses_name + temp.teachers_name + "(" + temp.startweek + "-" + temp.endweek + ")";
                                break;
                        }
                    }
                }
            }
            result.code = 0;
            result.data = list;
            return result;
        }
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
            result.count = dalClasstimeAll.List((int)users.collegeid).Count;
            result.data = dalClasstimeAll.List((int)users.collegeid,page, limit);
            return result;
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="users"></param>
        /// <param name="classtime"></param>
        /// <returns></returns>
        /// 修改时间 2018-9-19 22:10:16
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

            if (classtime.coursesid != null && dalCourses.Single((int)classtime.coursesid).collegeid != classtime.collegeid)
            {
                result.code = -2;
                result.msg = "该学院无此课程！请检查讲师所属学院！";
                return result;
            }

            if (classtime.collegeid != null&& classtime.subclassesid !=null&& classtime.coursesid!=null)
            {
                int ishave = dalBasedata.IsHave((int)classtime.collegeid, (int)classtime.subclassesid, (int)classtime.coursesid);
                if (ishave == 0)
                {
                    basedata basedata = new basedata();
                    basedata.collegeid = classtime.collegeid;
                    basedata.subclassesid = classtime.subclassesid;
                    basedata.coursesid = classtime.coursesid;
                    ishave = dalBasedata.Add(basedata);
                }

                classtimeTemp.basedataid = ishave;
            }

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
