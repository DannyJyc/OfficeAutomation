using System.Collections.Generic;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_Twolevel
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 查询一条
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public twolevel Single(int id)
        {
            return dbContext.Query<twolevel>().Where(p => p.id == id).FirstOrDefault();
        }
        
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public List<twolevel> List(int page, int limit)
        {
            return dbContext.Query<twolevel>().Where(p => p.id > 0).TakePage(page, limit).ToList();
        }
        /// <summary>
        /// 根据一级id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<twolevel> List(int id)
        {
            return dbContext.Query<twolevel>().Where(p => p.one_id == id).ToList();
        }
        public List<twolevel> List()
        {
            return dbContext.Query<twolevel>().Where(p => p.id > 0).ToList();
        }
        public int Count()
        {
            return dbContext.Query<twolevel>().Where(p => p.id > 0).Count();
        }
        public List<view_two_one> ListView(int page, int limit)
        {
            return dbContext.Query<view_two_one>().Where(p => p.id > 0).TakePage(page, limit).ToList();
        }

        public int CountView()
        {
            return dbContext.Query<view_two_one>().Where(p => p.id > 0).Count();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del(int id)
        {
            return dbContext.Delete<twolevel>(p => p.id == id);
        }
        /// <summary>
        /// 根据一级id删除
        /// </summary>
        /// <param name="Oid"></param>
        /// <returns></returns>
        public int DelByOne(int Oid)
        {
            return dbContext.Delete<twolevel>(p => p.one_id == Oid);
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="twolevel"></param>
        /// <returns></returns>
        public int Update(twolevel twolevel)
        {
            return dbContext.Update<twolevel>(p => p.id == twolevel.id, p => new twolevel()
            {
                name = twolevel.name,
                one_id = twolevel.one_id
            });
        }
        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="twolevel"></param>
        /// <returns></returns>
        public int Add(twolevel twolevel)
        {
            return (int)dbContext.Insert<twolevel>(() => new twolevel()
            {
                name = twolevel.name,
                one_id = twolevel.one_id
            });
        }
    }
}
