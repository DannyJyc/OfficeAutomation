using Chloe.MySql;
using log4net;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.BLL
{
    public class BLL_Twolevel
    {
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));
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
            result.count = dalTwolevel.CountView();
            result.data = dalTwolevel.ListView(page, limit);
            return result;
        }
        /// <summary>
        /// 新增/修改
        /// </summary>
        /// <param name="onelevel"></param>
        /// <returns></returns>
        public BaseResult Update(twolevel twolevel)
        {
            result.code = 0;
            result.msg = "操作成功";
            if (twolevel.id == 0)
            {
                var insert = dalTwolevel.Add(twolevel);
                if (insert <= 0)
                {
                    result.code = -1;
                    result.msg = "增加失败";
                }
                return result;
            }

            var update = dalTwolevel.Update(twolevel);
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
                    var Del = dalTwolevel.Del(id);
                    var ThreeDel = dalThreelevel.DelByTwo(id);
                    if (Del <= 0 || ThreeDel <= 0)
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
