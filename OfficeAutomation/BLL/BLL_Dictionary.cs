using System;
using log4net;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.BLL
{
    public class BLL_Dictionary
    {
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));
        private DAL.DAL_Dictionary dalDictionary = new DAL_Dictionary();
        BaseResult result = new BaseResult();
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public BaseResult List(int page, int limit)
        {
            result.code = 0;
            result.count = dalDictionary.List().Count;
            result.data = dalDictionary.List(page, limit);
            return result;
        }
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public BaseResult Del(int id)
        {
            var value = dalDictionary.Single(id).value;
            result.code = 0;
            if (dalDictionary.DelDictionary(value) == 0)
            {
                result.code = -1;
                result.msg = "删除失败，找不到对应角色";
            }
            else
            {
                dalDictionary.DelRelated(value);
            }

            return result;
        }
        /// <summary>
        /// 更新角色
        /// </summary>
        /// <param name="related"></param>
        /// <returns></returns>
        public BaseResult Update(related related)
        {
            result.code = 0;
            if (related.id == 0)
            {
                dalDictionary.AddDictionary(related.dicvalue);
            }
            else
            {
                dalDictionary.UpdateDictionary(related.dicvalue, related.NotMapped);
                dalDictionary.UpdateRelated(related.dicvalue, related.NotMapped);
            }

            dalDictionary.DelRelated(related.dicvalue);
            string effect = related.reserve1;
            if (effect == null || effect == "")
            {
                return result;
            }

            if (!effect.Contains(","))
            {
                dalDictionary.AddRelated(related.dicvalue, Convert.ToInt16(effect));
                return result;
            }

            string[] effectarr = effect.Split(',');
            foreach (var i in effectarr)
            {
                dalDictionary.AddRelated(related.dicvalue, Convert.ToInt16(i));
            }

            return result;
        }
    }
}
