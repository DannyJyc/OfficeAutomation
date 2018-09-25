using System.Collections.Generic;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_Effect
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 所有功能数据
        /// </summary>
        /// <returns></returns>
        public List<effect> List()
        {
            return dbContext.Query<effect>().Where(p => p.id > 0).ToList();
        }
        /// <summary>
        /// 所有功能数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<effect> List(int page, int limit)
        {
            return dbContext.Query<effect>().Where(p => p.id > 0).TakePage(page, limit).ToList();
        }
        /// <summary>
        /// 对应id功能
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public effect Single(int id)
        {
            return dbContext.Query<effect>().Where(p => p.id == id).FirstOrDefault();
        }
        public effect Single(string name)
        {
            return dbContext.Query<effect>().Where(p => p.name == name).FirstOrDefault();
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="effect"></param>
        /// <returns></returns>
        public int Add(effect effect)
        {
            return (int)dbContext.Insert<effect>(() => new effect()
            {
                name = effect.name,
                controller = effect.controller
            });
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="effect"></param>
        /// <returns></returns>
        public int Update(effect effect)
        {
            return dbContext.Update<effect>(p => p.id == effect.id, p => new effect()
            {
                name = effect.name,
                controller = effect.controller
            });
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del(int id)
        {
            return dbContext.Delete<effect>(p => p.id == id);
        }
    }
}
