using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;

namespace OfficeAutomation.BLL
{
    public class BLL_Auditing
    {
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));
        private DAL.DAL_yunyingxiangmudengji dalYunyingxiangmudengji = new DAL_yunyingxiangmudengji();
        BaseResult baseResult = new BaseResult();

        public BaseResult List(int page, int limit)
        {
            baseResult.code = 0;
            baseResult.count = dalYunyingxiangmudengji.AuditingCount();
            baseResult.data = dalYunyingxiangmudengji.AuditingList(page, limit);
            return baseResult;
        }
    }
}
