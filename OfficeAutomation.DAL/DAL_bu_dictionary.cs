using System.Collections.Generic;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_bu_dictionary
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 获取所有事业部的信息
        /// </summary>
        /// <returns></returns>
        public List<bu_dictionary> List()
        {
            return dbContext.Query<bu_dictionary>().Where(p => p.id > 0).ToList();
        }
    }
}
