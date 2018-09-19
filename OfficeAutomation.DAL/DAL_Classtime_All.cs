using System.Collections.Generic;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_Classtime_All
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 根据班级id和学院id返回对应所有班级
        /// </summary>
        /// <param name="classesid"></param>
        /// <returns></returns>
        public List<view_sub_classes_college> GetSubByClassesId(int collegeid)
        {
            return dbContext.Query<view_sub_classes_college>().Where(p => p.college_id == collegeid).ToList();
        }
        public List<view_sub_classes_college> GetSubByClassesId(int collegeid,int classesid)
        {
            return dbContext.Query<view_sub_classes_college>().Where(p => p.classesid == classesid&&p.college_id== collegeid).ToList();
        }

        /// <summary>
        /// 所有课表
        /// </summary>
        /// <returns></returns>
        public List<view_classtime_all> List()
        {
            return dbContext.Query<view_classtime_all>().Where(p => p.id > 0).ToList();
        }
        /// <summary>
        /// 所有课表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<view_classtime_all> List(int page, int limit)
        {
            return dbContext.Query<view_classtime_all>().Where(p => p.id > 0).TakePage(page, limit).ToList();
        }
        /// <summary>
        /// 对应角色课表
        /// </summary>
        /// <param name="collegeid"></param>
        /// <returns></returns>
        public List<view_classtime_all> List(int collegeid)
        {
            return dbContext.Query<view_classtime_all>().Where(p => p.collegeid == collegeid).ToList();

        }
        /// <summary>
        /// 对应角色课表
        /// </summary>
        /// <param name="collegeid"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<view_classtime_all> List(int collegeid, int page, int limit)
        {
            return dbContext.Query<view_classtime_all>().Where(p => p.collegeid == collegeid).ToList();

        }
        /// <summary>
        /// 对应id课表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public view_classtime_all Single(int id)
        {
            return dbContext.Query<view_classtime_all>().Where(p => p.id == id).FirstOrDefault();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del(int id)
        {
            return dbContext.Delete<classtime>(p => p.id == id);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="classtime"></param>
        /// <returns></returns>
        public int Add(classtime classtime)
        {
            return (int)dbContext.Insert<classtime>(() => new classtime()
            {
                basedataid = classtime.basedataid,
                week = classtime.week,
                lesson = classtime.lesson,
                classroom = classtime.classroom
            });
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="classtime"></param>
        /// <returns></returns>
        public int Update(classtime classtime)
        {
            return dbContext.Update<classtime>(p => p.id == classtime.id, p => new classtime()
            {
                basedataid = classtime.basedataid,
                week = classtime.week,
                lesson = classtime.lesson,
                classroom = classtime.classroom
            });
        }
        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="collegeid"></param>
        /// <param name="classesid"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        /// 修改时间 2018-9-19 21:12:10 新增专业下的班级实体
        public view_classtime_all ListByWhere(int collegeid, int classesid, int week,int w,int l)
        {
            if (week == 0)
            {
                return dbContext.Query<view_classtime_all>().Where(p =>
                    p.collegeid == collegeid && p.subclassesid == classesid && p.week == w && p.lesson == l).FirstOrDefault();

            }
            return dbContext.Query<view_classtime_all>().Where(p =>
                p.collegeid == collegeid && p.subclassesid == classesid && p.startweek <= week && p.endweek >= week&&p.week==w&&p.lesson==l).FirstOrDefault();
        }

        public view_classtime_all ListByWhere(int teachersid, int w, int l)
        {
            return dbContext.Query<view_classtime_all>().Where(p =>
                p.teachersid == teachersid && p.week == w && p.lesson == l).FirstOrDefault();
        }
        /// <summary>
        /// 列出指定学院的专业
        /// </summary>
        /// <param name="collegeid"></param>
        /// <returns></returns>
        public List<view_data_all_group> ListDesignatedClass(int collegeid)
        {
            return dbContext.Query<view_data_all_group>().Where(p => p.collegeid == collegeid).ToList();
        }
    }
}

