using System.Linq;
using Chloe.MySql;
using log4net;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.BLL
{
    public class BLL_Onelevel
    {
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));
        private DAL.DAL_Onelevel dalOnelevel = new DAL_Onelevel();
        private DAL.DAL_Twolevel dalTwolevel = new DAL_Twolevel();
        private DAL.DAL_Threelevel dalThreelevel = new DAL_Threelevel();
        BaseResult result = new BaseResult();
        /// <summary>
        /// 所有数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public BaseResult List(int page, int limit)
        {
            result.code = 0;
            result.count = dalOnelevel.Count();
            result.data = dalOnelevel.List(page, limit);
            return result;
        }
        /// <summary>
        /// 新增/修改
        /// </summary>
        /// <param name="onelevel"></param>
        /// <returns></returns>
        public BaseResult Update(onelevel onelevel)
        {
            result.code = 0;
            result.msg = "操作成功";
            if (onelevel.id == 0)
            {
                var insert = dalOnelevel.Add(onelevel);
                if (insert <= 0)
                {
                    result.code = -1;
                    result.msg = "增加失败";
                }
                return result;
            }

            var update = dalOnelevel.Update(onelevel);
            if (update <= 0)
            {
                result.code = -1;
                result.msg = "修改失败";
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
            result.msg = "操作成功";
            using (MySqlContext context = new MySqlContext(new MySqlConnectionFactory()))
            {
                try
                {
                    context.Session.BeginTransaction();

                    var Del = dalOnelevel.Del(id);
                    var List = dalTwolevel.List(id);
                    var Tdel = dalTwolevel.DelByOne(id);
                    if (List.Count > 0)
                    {
                        foreach (var temp in List)
                        {
                            var deltwo = dalThreelevel.DelByTwo(temp.id);
                            if (deltwo <= 0)
                            {
                                result.code = -1;
                                result.msg = "删除失败";
                                return result;
                            }
                        }
                    }
                    if (Del <= 0 || Tdel <= 0)
                    {
                        result.code = -1;
                        result.msg = "删除失败";
                    }
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
