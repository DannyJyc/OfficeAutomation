using log4net;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.BLL
{
    public class BLL_College
    {
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));
        private DAL.DAL_College dalCollege = new DAL_College();
        BaseResult result = new BaseResult();

        /// <summary>
        /// 所有学院信息
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public BaseResult List(int page, int limit)
        {
            result.code = 0;
            result.count = dalCollege.List().Count;
            result.data = dalCollege.List(page, limit);
            return result;
        }
        /// <summary>
        /// 更新学院
        /// </summary>
        /// <param name="college"></param>
        /// <returns></returns>
        public BaseResult UpdateCollege(college college)
        {
            result.code = 0;
            if (college.id != 0)
            {
                if (dalCollege.UpdateCollege(college) == 0)
                {
                    result.code = -1;
                    result.msg = "修改失败";
                }
                else { }
            }
            else
            {
                if (dalCollege.AddCollege(college) == 0)
                {
                    result.code = -1;
                    result.msg = "添加失败";
                }
                else { }
            }

            return result;
        }
        /// <summary>
        /// 删除学院
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BaseResult DelUser(int id)
        {
            result.code = 0;
            if (dalCollege.DelCollege(id) == 0)
            {
                result.code = -1;
                result.msg = "删除失败，找不到对应学院";
            }
            else { }

            return result;
        }
    }
}
