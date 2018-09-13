using System.Collections.Generic;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_Teachers
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();

        /// <summary>
        /// 返回对应老师
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public view_teachers_college Single(int id)
        {
            return dbContext.Query<view_teachers_college>().Where(p => p.id == id).FirstOrDefault();
        }
        /// <summary>
        /// 所有老师
        /// </summary>
        /// <returns></returns>
        public List<view_teachers_college> List()
        {
            return dbContext.Query<view_teachers_college>().Where(p => p.id > 0).ToList();
        }
        /// <summary>
        /// 所有老师
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<view_teachers_college> List(int page, int limit)
        {
            return dbContext.Query<view_teachers_college>().Where(p => p.id > 0).TakePage(page, limit).ToList();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del(int id)
        {
            return dbContext.Delete<teachers>(p => p.id == id);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public int Update(teachers teachers)
        {
            return dbContext.Update<teachers>(p => p.id == teachers.id, p => new teachers()
            {
                name = teachers.name,
                collegeid = teachers.collegeid
                
            });
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public int Add(teachers teachers)
        {
            return (int)dbContext.Insert<teachers>(() => new teachers()
            {
                name = teachers.name,
                collegeid = teachers.collegeid
            });
        }
    }
}
