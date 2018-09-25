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
        /// <summary>
        /// 对应id角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public dictionary Single(int id)
        {
            return dbContext.Query<dictionary>().Where(p => p.id == id).FirstOrDefault();
        }

        public dictionary Single(string value)
        {
            return dbContext.Query<dictionary>().Where(p => p.value == value).FirstOrDefault();

        }
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="dicvalue"></param>
        /// <returns></returns>
        public int DelDictionary(string dicvalue)
        {
            return dbContext.Delete<dictionary>(p => p.value == dicvalue);
        }
        /// <summary>
        /// 删除关联
        /// </summary>
        /// <param name="dicvalue"></param>
        /// <returns></returns>
        public int DelRelated(string dicvalue)
        {
            return dbContext.Delete<related>(p => p.dicvalue == dicvalue);
        }
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="value"></param>
        /// <param name="once"></param>
        /// <returns></returns>
        public int UpdateDictionary(string value,string once)
        {
            return dbContext.Update<dictionary>(p => p.value == once, p => new dictionary()
            {
                value = value
            });
        }
        /// <summary>
        /// 修改关联
        /// </summary>
        /// <param name="value"></param>
        /// <param name="once"></param>
        /// <returns></returns>
        public int UpdateRelated(string value, string once)
        {
            return dbContext.Update<related>(p => p.dicvalue == once, p => new related()
            {
                dicvalue = value
            });
        }
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int AddDictionary(string value)
        {
            return (int) dbContext.Insert<dictionary>(() => new dictionary()
            {
                key = "角色",
                value = value
            });
        }
        /// <summary>
        /// 添加关联
        /// </summary>
        /// <param name="value"></param>
        /// <param name="effectid"></param>
        /// <returns></returns>
        public int AddRelated(string value, int effectid)
        {
            return (int)dbContext.Insert<related>(() => new related()
            {
                dicvalue = value,
                effectid = effectid
            }); 
        }
        /// <summary>
        /// 对应角色是否有对应功能
        /// </summary>
        /// <param name="dicvalue"></param>
        /// <param name="effectid"></param>
        /// <returns></returns>
        public int IfRelatedByRole(string dicvalue, int effectid)
        {
            return dbContext.Query<related>().Where(p => p.dicvalue == dicvalue && p.effectid == effectid).Count();
        }
    }
}
