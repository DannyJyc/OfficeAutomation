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
        /// 对应id用户是否有对应控制器权限
        /// </summary>
        /// <param name="id"></param>
        /// <param name="controller"></param>
        /// <returns></returns>
        public bool IsHaveEffect(int id, string controller)
        {
            var single = dbContext.Query<view_users_effect>().Where(p => p.id == id && p.controller == controller)
                .FirstOrDefault();
            if (single == null)
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// 对应userid是否有控制下级权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsHaveControl(int id)
        {
            var single = dbContext.Query<view_users_college>().Where(p => p.id == id).FirstOrDefault();
            if (single.control != 1)
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// 修改用户的角色名
        /// </summary>
        /// <param name="value"></param>
        /// <param name="once"></param>
        /// <returns></returns>
        public int UpdateByDicvalue(string value, string once)
        {
            return dbContext.Update<users>(p => p.dicvalue == once, p => new users()
            {
                dicvalue = value
            });
        }
        /// <summary>
        /// 返回对应id的用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public view_users_college SingleUsers(int id)
        {
            return dbContext.Query<view_users_college>().Where(p => p.id == id).FirstOrDefault();
        }
        public view_users_college SingleUsers(string name)
        {
            return dbContext.Query<view_users_college>().Where(p => p.name == name||p.username==name).FirstOrDefault();
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

        public List<view_users_college> List(int lowid, int page, int limit)
        {
            return dbContext.Query<view_users_college>().Where(p => p.level>lowid).TakePage(page, limit).ToList();
        }

        public int Count()
        {
            return dbContext.Query<view_users_college>().Where(p => p.id > 0).Count();
        }
        public int Count(int lowid)
        {
            return dbContext.Query<view_users_college>().Where(p => p.level > lowid).Count();
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
        /// 是否能控制下级
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public int EditControl(int id, int type)
        {
            return dbContext.Update<users>(p => p.id == id, p => new users()
            {
                control = type
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
        /// 根据角色名称删除对应用户
        /// </summary>
        /// <param name="dicvalue"></param>
        /// <returns></returns>
        public int DelUser(string dicvalue)
        {
            return dbContext.Delete<users>(p => p.dicvalue == dicvalue);
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
