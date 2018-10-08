using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.BLL
{
    public class BLL_knowledge
    {
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));
        BaseResult baseResult = new BaseResult();
        private DAL.DAL_knowledge dalKnowledge = new DAL_knowledge();
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        public BaseResult List(int page,int limit,string type)
        {
            if (type != "" && type != null)
            {
                baseResult.code = 0;
                baseResult.count = dalKnowledge.List(type).Count;
                baseResult.data = dalKnowledge.List(page, limit, type);
                return baseResult;
            }
            baseResult.code = 0;
            baseResult.count = dalKnowledge.List().Count;
            baseResult.data = dalKnowledge.List(page, limit);
            return baseResult;
        }
        /// <summary>
        /// 获取分类信息
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public BaseResult TypeList(int page, int limit)
        {
            baseResult.code = 0;
            baseResult.count = dalKnowledge.TypeList().Count;
            baseResult.data = dalKnowledge.TypeList(page, limit);
            return baseResult;
        }
        /// <summary>
        /// 新增一条分类
        /// </summary>
        /// <param name="knowledgetype"></param>
        /// <returns></returns>
        public BaseResult TypeAdd(knowledgetype knowledgetype)
        {
            var insert = dalKnowledge.AddType(knowledgetype);
            if (insert <= 0)
            {
                baseResult.code = -1;
                baseResult.msg = "操作失败";
                return baseResult;
            }
            baseResult.code = 0;
            baseResult.msg = "操作成功";
            return baseResult;
        }
        /// <summary>
        /// 修改持有状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public BaseResult UpdateState(int id, int state)
        {
            var update = dalKnowledge.UpdateState(id, state);
            if (update == 0)
            {
                baseResult.code = -1;
                baseResult.msg = "操作失败";
                return baseResult;
            }
            baseResult.code = 0;
            baseResult.msg = "操作成功";
            return baseResult;
        }
        /// <summary>
        /// 返回对应用户的所有
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public BaseResult GetAdmin(int page, int limit, int userid)
        {
            baseResult.code = 0;
            baseResult.count = dalKnowledge.List(userid).Count;
            baseResult.data = dalKnowledge.List(page, limit,userid);
            return baseResult;
        }
        /// <summary>
        /// 添加回复
        /// </summary>
        /// <param name="knowledge"></param>
        /// <returns></returns>
        public BaseResult Reply(knowledge knowledge)
        {
            var insert = dalKnowledge.AddReply(knowledge);
            if(insert<=0)
            {
                baseResult.code = -1;
                baseResult.msg = "操作失败";
                return baseResult;
            }
            baseResult.code = 0;
            baseResult.msg = "操作成功";
            return baseResult;
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="knowledge"></param>
        /// <returns></returns>
        public BaseResult Add(knowledge knowledge)
        {
            var insert = dalKnowledge.Add(knowledge);
            if (insert <= 0)
            {
                baseResult.code = -1;
                baseResult.msg = "操作失败";
                return baseResult;
            }
            baseResult.code = 0;
            baseResult.msg = "操作成功";
            return baseResult;
        }
    }
}
