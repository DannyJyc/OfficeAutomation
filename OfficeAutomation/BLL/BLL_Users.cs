using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;

namespace OfficeAutomation.BLL
{
    public class BLL_Users
    {
        private DAL.DAL_User dalUser = new DAL_User();
        private BaseResult result = new BaseResult();
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
            return result;
        }
    }
}
