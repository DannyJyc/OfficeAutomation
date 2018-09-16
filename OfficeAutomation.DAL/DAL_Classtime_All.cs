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
    }
}

