using System;
using System.Collections.Generic;
using System.Text;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_College
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();

        /// <summary>
        /// 对应id的学院数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public college Single(int id)
        {
            return dbContext.Query<college>().Where(p => p.id == id).FirstOrDefault();
        }
        /// <summary>
        /// 所有学院
        /// </summary>
        /// <returns></returns>
        public List<college> List()
        {
            return dbContext.Query<college>().Where(p => p.id > 0).ToList();
        }
        /// <summary>
        /// 所有学院
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<college> List(int page, int limit)
        {
            return dbContext.Query<college>().Where(p => p.id > 0).TakePage(page, limit).ToList();
        }
        /// <summary>
        /// 添加学院
        /// </summary>
        /// <param name="college"></param>
        /// <returns></returns>
        public int AddCollege(college college)
        {
            return (int)dbContext.Insert<college>(() => new college()
            {
                name = college.name
            });
        }
        /// <summary>
        /// 修改学院
        /// </summary>
        /// <param name="college"></param>
        /// <returns></returns>
        public int UpdateCollege(college college)
        {
            return dbContext.Update<college>(p => p.id == college.id, p => new college()
            {
                name = college.name
            });
        }
        /// <summary>
        /// 删除学院
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelCollege(int id)
        {
            return dbContext.Delete<college>(p => p.id == id);
        }
    }
}
