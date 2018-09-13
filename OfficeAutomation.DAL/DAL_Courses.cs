using System.Collections.Generic;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_Courses
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();

        /// <summary>
        /// 返回对应课程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public view_courses_teachers Single(int id)
        {
            return dbContext.Query<view_courses_teachers>().Where(p => p.id == id).FirstOrDefault();
        }
        /// <summary>
        /// 所有课程
        /// </summary>
        /// <returns></returns>
        public List<view_courses_teachers> List()
        {
            return dbContext.Query<view_courses_teachers>().Where(p => p.id > 0).ToList();
        }
        /// <summary>
        /// 所有课程
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<view_courses_teachers> List(int page, int limit)
        {
            return dbContext.Query<view_courses_teachers>().Where(p => p.id > 0).TakePage(page, limit).ToList();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del(int id)
        {
            return dbContext.Delete<courses>(p => p.id == id);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public int Update(courses courses)
        {
            return dbContext.Update<courses>(p => p.id == courses.id, p => new courses()
            {
                name = courses.name,
                teachersid = courses.teachersid

            });
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public int Add(courses courses)
        {
            return (int)dbContext.Insert<courses>(() => new courses()
            {
                name = courses.name,
                teachersid = courses.teachersid
            });
        }
    }
}
