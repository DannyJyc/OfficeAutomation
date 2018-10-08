using System;
using System.Collections.Generic;
using Chloe;
using OfficeAutomation.DAL.DB;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL
{
    public class DAL_knowledge
    {
        private IDbContext dbContext = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 查询一条
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public view_knowledge_user Single(int id)
        {
            return dbContext.Query<view_knowledge_user>().Where(p => p.id == id).FirstOrDefault();
        }
        /// <summary>
        /// 查询回复的
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<view_knowledge_user> Reply(int id)
        {
            return dbContext.Query<view_knowledge_user>()
                .Where(p => p.reply == id && p.reReply == null || p.reReply == 0).ToList();
        }

        public List<view_knowledge_user> reReply(int id)
        {
            return dbContext.Query<view_knowledge_user>().Where(p => p.reReply == id).ToList();
        }
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        public List<view_knowledge_type> List()
        {
            return dbContext.Query<view_knowledge_type>().Where(p => p.id > 0).ToList();
        }

        public List<view_knowledge_type> List(string type)
        {
            return dbContext.Query<view_knowledge_type>().Where(p =>
                p.state == 1 && (p.title.Contains(type) || p.title.StartsWith(type) || p.title.EndsWith(type) ||
                                 p.name.Contains(type) || p.name.StartsWith(type) || p.name.EndsWith(type))).ToList();
        }
        public List<view_knowledge_type> List(int page, int limit, string type)
        {
            return dbContext.Query<view_knowledge_type>().Where(p =>
                p.state == 1 && (p.title.Contains(type) || p.title.StartsWith(type) || p.title.EndsWith(type) ||
                                 p.name.Contains(type) || p.name.StartsWith(type) || p.name.EndsWith(type))).TakePage(page, limit).ToList();
        }
        public List<view_knowledge_type> List(int page, int limit)
        {
            return dbContext.Query<view_knowledge_type>().Where(p =>
                p.state == 1).TakePage(page, limit).ToList();
        }

        public List<view_knowledge_type> List(int id)
        {
            return dbContext.Query<view_knowledge_type>().Where(p => p.userid == id).ToList();
        }
        public List<view_knowledge_type> List(int page, int limit,int id)
        {
            return dbContext.Query<view_knowledge_type>().Where(p =>
                p.userid == id).TakePage(page, limit).ToList();
        }
        /// <summary>
        /// 修改所有状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public int UpdateState(int id,int state)
        {
            return dbContext.Update<knowledge>(p => p.id == id, p => new knowledge()
            {
                state = state
            });
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="knowledge"></param>
        /// <returns></returns>
        public int Add(knowledge knowledge)
        {
            return (int) dbContext.Insert<knowledge>(() => new knowledge()
            {
                addtime = DateTime.Now,
                title = knowledge.title,
                content = knowledge.content,
                urlstr = knowledge.urlstr,
                state = 1,
                typeid = knowledge.typeid
            });
        }
        /// <summary>
        /// 添加回复
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int AddReply(knowledge knowledge)
        {
            if (knowledge.reReply == 0)
            {
                return (int) dbContext.Insert<knowledge>(() => new knowledge()
                {
                    addtime = DateTime.Now,
                    content = knowledge.content,
                    userid = knowledge.userid,
                    reply = knowledge.reply
                });
            }
            return (int)dbContext.Insert<knowledge>(() => new knowledge()
            {
                addtime = DateTime.Now,
                content = knowledge.content,
                userid = knowledge.userid,
                reply = knowledge.reply,
                reReply = knowledge.reReply
            });
        }

        /// <summary>
        /// 返回分类
        /// </summary>
        /// <returns></returns>
        public List<knowledgetype> TypeList()
        {
            return dbContext.Query<knowledgetype>().Where(p => p.id > 0).ToList();
        }

        public List<knowledgetype> TypeList(int page, int limit)
        {
            return dbContext.Query<knowledgetype>().Where(p => p.id > 0).TakePage(page,limit).ToList();

        }
        /// <summary>
        /// 新增一条分类
        /// </summary>
        /// <param name="Knowledgetype"></param>
        /// <returns></returns>
        public int AddType(knowledgetype Knowledgetype)
        {
            return (int) dbContext.Insert<knowledgetype>(() => new knowledgetype()
            {
                name = Knowledgetype.name
            });
        }
    }
}
