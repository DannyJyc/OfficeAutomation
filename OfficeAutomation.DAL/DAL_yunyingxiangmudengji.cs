using System.Collections.Generic;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_yunyingxiangmudengji
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();

        /// <summary>
        /// 返回对应id数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public yunyingxiangmudengji Single(int id)
        {
            return dbContext.Query<yunyingxiangmudengji>().Where(p => p.id == id).FirstOrDefault();
        }
        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns></returns>
        public List<yunyingxiangmudengji> List(int page,int limit)
        {
            return dbContext.Query<yunyingxiangmudengji>().Where(p => p.id > 0).TakePage(page,limit).ToList();
        }

        public int Count()
        {
            return dbContext.Query<yunyingxiangmudengji>().Where(p => p.id > 0).Count();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="yunyingxiangmudengji"></param>
        /// <returns></returns>
        public int Add(yunyingxiangmudengji yunyingxiangmudengji)
        {
            return (int)dbContext.Insert<yunyingxiangmudengji>(()=>new yunyingxiangmudengji()
            {
                s_province = yunyingxiangmudengji.s_province,
                s_city = yunyingxiangmudengji.s_city,
                s_county = yunyingxiangmudengji.s_county,
                address = yunyingxiangmudengji.address,
                didian = yunyingxiangmudengji.didian,
                lou = yunyingxiangmudengji.lou,
                fangjianhao = yunyingxiangmudengji.fangjianhao,
                didiancanquan = yunyingxiangmudengji.didiancanquan,
                didianendetime = yunyingxiangmudengji.didianendetime,
                lianxirenjia = yunyingxiangmudengji.lianxirenjia,
                number = yunyingxiangmudengji.number,
                phonejia = yunyingxiangmudengji.phonejia,
                teljia = yunyingxiangmudengji.teljia,
                emailjia = yunyingxiangmudengji.emailjia,
                lianxirenyi = yunyingxiangmudengji.lianxirenyi,
                phoneyi = yunyingxiangmudengji.phoneyi,
                telyi = yunyingxiangmudengji.telyi,
                emailyi = yunyingxiangmudengji.emailyi,
                zhuzhijiagoumingcheng = yunyingxiangmudengji.zhuzhijiagoumingcheng,
                yunyingmingcheng = yunyingxiangmudengji.yunyingmingcheng,
                jiancheng = yunyingxiangmudengji.jiancheng,
                yifang = yunyingxiangmudengji.yifang,
                jianchngyi = yunyingxiangmudengji.jianchngyi,
                yunyingchanquan = yunyingxiangmudengji.yunyingchanquan,
                addtime = yunyingxiangmudengji.addtime,
                endtime = yunyingxiangmudengji.endtime,
                state = 2
            });
        }
    }
}
