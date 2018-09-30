using log4net;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.BLL
{
    public class BLL_Threelevel
    {
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));
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
            result.count = dalThreelevel.CountView();
            result.data = dalThreelevel.ListView(page, limit);
            return result;
        }
        /// <summary>
        /// 新增/修改
        /// </summary>
        /// <param name="onelevel"></param>
        /// <returns></returns>
        public BaseResult Update(threelevel threelevel)
        {
            result.code = 0;
            result.msg = "操作成功";
            if (threelevel.id == 0)
            {
                var insert = dalThreelevel.Add(threelevel);
                if (insert <= 0)
                {
                    result.code = -1;
                    result.msg = "增加失败";
                }
                return result;
            }

            var update = dalThreelevel.Update(threelevel);
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
            var Del = dalThreelevel.Del(id);
            if (Del <= 0)
            {
                result.code = -1;
                result.msg = "删除失败";
            }

            return result;
        }
        /// <summary>
        /// 修改状态    
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BaseResult UpdateState(int id,int state)
        {
            result.code = 0;
            result.msg = "操作成功";
            var updatestate = dalThreelevel.UpdateState(id,state);
            if (updatestate <= 0)
            {
                result.code = -1;
                result.msg = "操作失败";
            }

            return result;
        }
    }
}
