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
        public users SingleUsers(int id)
        {
            return dbContext.Query<users>().Where(p => p.id > 0).FirstOrDefault();
        }

        /// <summary>
        /// 登录判断
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public users UserValidate(string username, string password)
        {
            return dbContext.Query<users>().Where(p => p.username==username&&p.password==password).FirstOrDefault();

        }
    }
}
