using System.Collections.Generic;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_Dictionary
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();

        /// <summary>
        /// 获取所有角色
        /// </summary>
        /// <returns></returns>
        public List<dictionary> List()
        {
            return dbContext.Query<dictionary>().Where(p => p.id > 0).ToList();

        }
        /// <summary>
        /// 获取所有角色
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<dictionary> List(int page,int limit)
        {
            return dbContext.Query<dictionary>().Where(p => p.id > 0).TakePage(page,limit).ToList();
        }
    }
}
