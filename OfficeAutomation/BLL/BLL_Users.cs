using log4net;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.BLL
{
    public class BLL_Users
    {
        private DAL.DAL_User dalUser = new DAL_User();
        private BaseResult result = new BaseResult();
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public BaseResult Validate(string username, string password)
        {
            var user = dalUser.UserValidate(username, password);
            result.code = 0;
            if (user == null)
            {
                result.code = -1;
                result.msg = "用户名或密码不正确";
            }
            result.data = user;
            log.Info("用户:\t" + username + "\t登陆成功");
            return result;
        }
        /// <summary>
        /// 所有用户信息
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public BaseResult List(users users, int page, int limit)
        {
            if (users.dicvalue != "0")
            {
                var single = dalUser.SingleUsers(users.id);
                result.code = 0;
                result.count = dalUser.Count((int)(1 + single.level));
                result.data = dalUser.List((int)(1 + single.level), page, limit);
                return result;
            }
            result.code = 0;
            result.count = dalUser.Count();
            result.data = dalUser.List(page, limit);
            return result;
        }
        /// <summary>
        /// 修改用户状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public BaseResult EditState(int id, int type)
        {
            result.code = 0;
            if (dalUser.EditState(id, type) == 0)
            {
                result.code = -1;
            }
            else { }

            return result;
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BaseResult DelUser(int id)
        {
            result.code = 0;
            if (dalUser.DelUser(id) == 0)
            {
                result.code = -1;
                result.msg = "删除失败，找不到对应用户";
            }
            else { }

            return result;
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public BaseResult AddUser(users users)
        {
            result.code = 0;
            var username = dalUser.SingleUsers(users.name);
            var name = dalUser.SingleUsers(username.name);
            if (username == null || name == null)
            {
                if (users.id != 0)
                {
                    if (dalUser.UpdateUsers(users) == 0)
                    {
                        result.code = -1;
                        result.msg = "修改失败";
                    }
                    else { }
                }
                else
                {
                    if (dalUser.AddUsers(users) == 0)
                    {
                        result.code = -1;
                        result.msg = "添加失败";
                    }
                    else { }
                }
            }
            else
            {
                result.code = -2;
                result.msg = "姓名或用户名重复";
            }

            return result;
        }
    }
}
