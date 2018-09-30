using System.Collections.Generic;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_Onelevel
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 查询一条
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public onelevel Single(int id)
        {
            return dbContext.Query<onelevel>().Where(p => p.id == id).FirstOrDefault();
        }
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public List<onelevel> List(int page,int limit)
        {
            return dbContext.Query<onelevel>().Where(p => p.id > 0).TakePage(page,limit).ToList();
        }
        public List<onelevel> List()
        {
            return dbContext.Query<onelevel>().Where(p => p.id > 0).ToList();
        }

        public List<onelevel> List(int id)
        {
            return dbContext.Query<onelevel>().Where(p => p.id == id).ToList();

        }
        public int Count()
        {
            return dbContext.Query<onelevel>().Where(p => p.id > 0).Count();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del(int id)
        {
            return dbContext.Delete<onelevel>(p => p.id == id);
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="onelevel"></param>
        /// <returns></returns>
        public int Update(onelevel onelevel)
        {
            return dbContext.Update<onelevel>(p => p.id == onelevel.id, p => new onelevel()
            {
                name = onelevel.name
            });
        }
        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="onelevel"></param>
        /// <returns></returns>
        public int Add(onelevel onelevel)
        {
            return (int) dbContext.Insert<onelevel>(() => new onelevel()
            {
                name = onelevel.name
            });
        }
    }
}
