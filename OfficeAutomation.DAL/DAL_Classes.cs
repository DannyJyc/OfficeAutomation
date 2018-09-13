using System.Collections.Generic;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_Classes
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();

        /// <summary>
        /// 返回对应专业
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public classes Single(int id)
        {
            return dbContext.Query<classes>().Where(p => p.id == id).FirstOrDefault();
        }
        /// <summary>
        /// 所有专业
        /// </summary>
        /// <returns></returns>
        public List<classes> List()
        {
            return dbContext.Query<classes>().Where(p => p.id > 0).ToList();
        }
        /// <summary>
        /// 所有专业
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<classes> List(int page, int limit)
        {
            return dbContext.Query<classes>().Where(p => p.id > 0).TakePage(page, limit).ToList();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del(int id)
        {
            return dbContext.Delete<classes>(p => p.id == id);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public int Update(classes classes)
        {
            return dbContext.Update<classes>(p => p.id == classes.id, p => new classes()
            {
                name = classes.name
            });
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public int Add(classes classes)
        {
            return (int)dbContext.Insert<classes>(() => new classes()
            {
                name = classes.name
            });
        }
    }
}
