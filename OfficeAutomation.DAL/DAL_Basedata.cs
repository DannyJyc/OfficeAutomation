using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_Basedata
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 基础数据中是否存在，真 返回对应字段id 否 0
        /// </summary>
        /// <param name="collegeid"></param>
        /// <param name="classesid"></param>
        /// <param name="coursesid"></param>
        /// <returns></returns>
        public int IsHave(int collegeid,int classesid,int coursesid)
        {
            var single = dbContext.Query<basedata>()
                .Where(p => p.collegeid == collegeid && p.classesid == classesid && p.coursesid == coursesid)
                .FirstOrDefault();
            if (single == null)
            {
                return 0;
            }

            return single.id;
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="basedata"></param>
        /// <returns></returns>
        public int Add(basedata basedata)
        {
            return (int) dbContext.Insert<basedata>(() => new basedata()
            {
                collegeid = basedata.collegeid,
                classesid = basedata.classesid,
                coursesid = basedata.coursesid
            });
        }
    }
}
