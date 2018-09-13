using log4net;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.BLL
{
    public class BLL_Classes
    {
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));
        private DAL.DAL_Classes dalClasses = new DAL_Classes();
        BaseResult result = new BaseResult();
        /// <summary>
        /// 返回数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public BaseResult List(int page, int limit)
        {
            result.code = 0;
            result.count = dalClasses.List().Count;
            result.data = dalClasses.List(page, limit);
            return result;
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="effect"></param>
        /// <returns></returns>
        public BaseResult Update(classes classes)
        {
            result.code = 0;
            if (classes.id != 0)
            {
                if (dalClasses.Update(classes) == 0)
                {
                    result.code = -1;
                    result.msg = "修改失败";
                }
                else { }
            }
            else
            {
                if (dalClasses.Add(classes) == 0)
                {
                    result.code = -1;
                    result.msg = "添加失败";
                }
                else { }
            }

            return result;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BaseResult Del(int id)
        {
            result.code = 0;
            if (dalClasses.Del(id) == 0)
            {
                result.code = -1;
                result.msg = "删除失败，找不到对应专业";
            }
            else { }

            return result;
        }
    }
}
