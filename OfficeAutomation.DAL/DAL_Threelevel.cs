using System.Collections.Generic;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_Threelevel
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 查询一条
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public threelevel Single(int id)
        {
            return dbContext.Query<threelevel>().Where(p => p.id == id).FirstOrDefault();
        }
        public List<view_three_two_o_name> SingleByOne(int Oid)
        {
            return dbContext.Query<view_three_two_o_name>().Where(p => p.one_id == Oid).ToList();
        }
        public view_three_two_o_name SingleByTwo(int Tid)
        {
            return dbContext.Query<view_three_two_o_name>().Where(p => p.two_id == Tid).FirstOrDefault();
        }
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public List<threelevel> List(int page, int limit)
        {
            return dbContext.Query<threelevel>().Where(p => p.id > 0).TakePage(page, limit).ToList();
        }
        public List<threelevel> List(int id)
        {
            return dbContext.Query<threelevel>().Where(p => p.two_id==id).ToList();
        }
        public int Count()
        {
            return dbContext.Query<threelevel>().Where(p => p.id > 0).Count();
        }

        public List<view_three_two_o_name> ListView(int page, int limit)
        {
            return dbContext.Query<view_three_two_o_name>().Where(p => p.id > 0).TakePage(page, limit).ToList();
        }

        public int CountView()
        {
            return dbContext.Query<view_three_two_o_name>().Where(p => p.id > 0).Count();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del(int id)
        {
            return dbContext.Delete<threelevel>(p => p.id == id);
        }
        /// <summary>
        /// 根据二级id删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelByTwo(int id)
        {
            return dbContext.Delete<threelevel>(p => p.two_id == id);
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="threelevel"></param>
        /// <returns></returns>
        public int Update(threelevel threelevel)
        {
            return dbContext.Update<threelevel>(p => p.id == threelevel.id, p => new threelevel()
            {
                name = threelevel.name,
                definition = threelevel.definition,
                according = threelevel.according,
                origin = threelevel.origin,
                two_id = threelevel.two_id
            });
        }
        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="threelevel"></param>
        /// <returns></returns>
        public int Add(threelevel threelevel)
        {
            return (int)dbContext.Insert<threelevel>(() => new threelevel()
            {
                name = threelevel.name,
                definition = threelevel.definition,
                according = threelevel.according,
                origin = threelevel.origin,
                two_id = threelevel.two_id,
                state = 1
            });
        }
        /// <summary>
        /// 修改状态
        /// </summary>
        /// <returns></returns>
        public int UpdateState(int id,int state)
        {
            return dbContext.Update<threelevel>(p => p.id == id, p => new threelevel()
            {
                state = state
            });
        }
    }
}
