using System.Collections.Generic;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    /// <summary>
    /// 用户
    /// </summary>
    public class DAL_User
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();

        /// <summary>
        /// 返回对应id的用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public view_users_college SingleUsers(int id)
        {
            return dbContext.Query<view_users_college>().Where(p => p.id == id).FirstOrDefault();
        }
        /// <summary>
        /// 列出所有用户数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<view_users_college> List(int page,int limit)
        {
            return dbContext.Query<view_users_college>().Where(p => p.id > 0).TakePage(page, limit).ToList();
        }

        public int Count()
        {
            return dbContext.Query<view_users_college>().Where(p => p.id > 0).Count();
        }
        /// <summary>
        /// 登录判断
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public view_users_college UserValidate(string username, string password)
        {
            return dbContext.Query<view_users_college>().Where(p => p.username==username&&p.password==password).FirstOrDefault();

        }
        /// <summary>
        /// 修改用户状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public int EditState(int id, int type)
        {
            return dbContext.Update<users>(p => p.id == id, p => new users()
            {
                state = type
            });
        }
        /// <summary>
        /// 删除对应用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelUser(int id)
        {
            return dbContext.Delete<users>(p => p.id == id);
        }
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int AddUsers(users users)
        {
            return (int) dbContext.Insert<users>(() => new users()
            {
                name = users.name,
                username = users.username,
                password = users.password,
                dicvalue = users.dicvalue,
                collegeid = users.collegeid,
                state = 1
            });
        }
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int UpdateUsers(users users)
        {
            return dbContext.Update<users>(p => p.id == users.id, p => new users()
            {
                name = users.name,
                username = users.username,
                password = users.password,
                dicvalue = users.dicvalue,
                collegeid = users.collegeid
            });
        }
    }
}
