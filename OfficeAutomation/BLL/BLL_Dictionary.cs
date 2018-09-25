using System;
using Chloe.MySql;
using log4net;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.BLL
{
    public class BLL_Dictionary
    {
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));
        private DAL.DAL_Dictionary dalDictionary = new DAL_Dictionary();
        private DAL.DAL_User dalUser = new DAL_User();
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
            using (MySqlContext context = new MySqlContext(new MySqlConnectionFactory()))
            {
                try
                {
                    context.Session.BeginTransaction();

                    if (dalDictionary.DelDictionary(value) == 0)
                    {
                        result.code = -1;
                        result.msg = "删除失败，找不到对应角色";
                    }
                    else
                    {
                        dalUser.DelUser(value);
                        dalDictionary.DelRelated(value);
                    }

                    context.Session.CommitTransaction();
                }
                catch
                {
                    result.code = -2;
                    result.msg = "操作失败";
                    if (context.Session.IsInTransaction)
                        context.Session.RollbackTransaction();
                    throw;
                }
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
            using (MySqlContext context = new MySqlContext(new MySqlConnectionFactory()))
            {
                try
                {
                    context.Session.BeginTransaction();
                    var single = dalDictionary.Single(related.dicvalue);
                    if (related.id == 0)
                    {
                        if (single == null)
                        {
                            dalDictionary.AddDictionary(related.dicvalue);
                        }
                        else
                        {
                            result.code = -1;
                            result.msg = "已存在该角色命名";
                            return result;
                        }
                    }
                    else
                    {
                        if (dalDictionary.UpdateDictionary(related.dicvalue, related.NotMapped) == 0 ||
                            dalDictionary.UpdateRelated(related.dicvalue, related.NotMapped) == 0 ||
                            dalUser.UpdateByDicvalue(related.dicvalue, related.NotMapped) == 0)
                        {
                            result.code = -2;
                            result.msg = "修改失败";
                            return result;
                        }
                    }

                    if (single != null)
                    {
                        result.code = -1;
                        result.msg = "已存在该角色命名";
                        return result;
                    }
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
                    context.Session.CommitTransaction();
                }
                catch
                {
                    result.code = -2;
                    result.msg = "操作失败";
                    if (context.Session.IsInTransaction)
                        context.Session.RollbackTransaction();
                    throw;
                }
            }

            return result;
        }
    }
}
