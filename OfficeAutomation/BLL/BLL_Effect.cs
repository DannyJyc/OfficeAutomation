using log4net;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.BLL
{
    public class BLL_Effect
    {
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));
        private DAL.DAL_Effect dalEffect = new DAL_Effect();
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
            result.count = dalEffect.List().Count;
            result.data = dalEffect.List(page, limit);
            return result;
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="effect"></param>
        /// <returns></returns>
        public BaseResult Update(effect effect)
        {
            result.code = 0;
            if (effect.id != 0)
            {
                if (dalEffect.Update(effect) == 0)
                {
                    result.code = -1;
                    result.msg = "修改失败";
                }
                else { }
            }
            else
            {
                if (dalEffect.Add(effect) == 0)
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
            if (dalEffect.Del(id) == 0)
            {
                result.code = -1;
                result.msg = "删除失败，找不到对应功能";
            }
            else { }

            return result;
        }
    }
}
