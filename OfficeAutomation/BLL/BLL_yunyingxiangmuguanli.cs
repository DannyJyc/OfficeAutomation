using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.BLL
{
    public class BLL_yunyingxiangmuguanli
    {
        private DAL.DAL_yunyingxiangmudengji dalYunyingxiangmudengji = new DAL_yunyingxiangmudengji();
        BaseResult baseResult = new BaseResult();
        /// <summary>
        /// 返回数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public BaseResult List(int page, int limit)
        {
            baseResult.code = 0;
            baseResult.count = dalYunyingxiangmudengji.Count();
            baseResult.data = dalYunyingxiangmudengji.List(page, limit);
            return baseResult;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="yunyingxiangmudengji"></param>
        /// <returns></returns>
        public BaseResult Add(yunyingxiangmudengji yunyingxiangmudengji)
        {
            baseResult.code = 0;
            baseResult.msg = "操作成功";
            var addresult = dalYunyingxiangmudengji.Add(yunyingxiangmudengji);
            if (addresult == 0)
            {
                baseResult.code = -1;
                baseResult.msg = "操作失败";
            }else if (addresult < 0)
            {
                baseResult.code = -2;
                baseResult.msg = "异常";
            }

            return baseResult;
        }
    }
}
