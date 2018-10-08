using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeAutomation.BLL;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.Controllers
{
    public class knowledgeController : Controller
    {
        private DAL.Helper.JsonUserConvert jsonUserConvert = new JsonUserConvert();

        private BLL.BLL_knowledge bllKnowledge = new BLL_knowledge();
        private DAL.DAL_knowledge dalKnowledge = new DAL_knowledge();
        private BLL.BLL_Users bllUsers = new BLL_Users();
        private IHostingEnvironment hostingEnv;
        public knowledgeController(IHostingEnvironment env)
        {
            this.hostingEnv = env;
        }
        public IActionResult All()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public JsonResult GetAdmin(int page,int limit)
        {
            return Json(bllKnowledge.GetAdmin(page, limit,jsonUserConvert.StringToObject(HttpContext.Session.GetString("users")).id));
        }

        public IActionResult AdminAdd()
        {
            return View(dalKnowledge.TypeList());
        }
        [HttpPost]
        public JsonResult Add(knowledge Knowledge)
        {
            Knowledge.userid = jsonUserConvert.StringToObject(HttpContext.Session.GetString("users")).id;
            return Json(bllKnowledge.Add(Knowledge));
        }
        /// <summary>
        /// 修改持有状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public JsonResult UpdateState(int id,int state)
        {
            return Json(bllKnowledge.UpdateState(id,state));
        }
        public JsonResult Get(int page, int limit, string type)
        {
            return Json(bllKnowledge.List(page,limit,type));
        }

        public IActionResult Content(int id)
        {
            return View(dalKnowledge.Single(id));
        }
        
        public IActionResult Reply(int reply, int rereply)
        {
            ViewBag.reply = reply;
            ViewBag.rereply = rereply;
            return View();
        }
        [HttpPost]
        public IActionResult Reply(knowledge knowledge)
        {
            knowledge.userid = jsonUserConvert.StringToObject(HttpContext.Session.GetString("users")).id;

            return Json(bllKnowledge.Reply(knowledge));
        }

        public IActionResult Type()
        {
            return View();
        }

        public JsonResult GetType(int page,int limit)
        {
            return Json(bllKnowledge.TypeList(page,limit));
        }

        public IActionResult AddType()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Addtype(knowledgetype knowledgetype)
        {
            return Json(bllKnowledge.TypeAdd(knowledgetype));
        }
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UpLoad()
        {
            var file = Request.Form.Files[0];
            var filename = file.FileName;
            var fileurl = @"\UpLoad" + $@"\{filename}";
            filename = hostingEnv.WebRootPath + @"\UpLoad" + $@"\{filename}";
            
            if (!Directory.Exists(hostingEnv.WebRootPath + @"\UpLoad"))
                Directory.CreateDirectory(hostingEnv.WebRootPath + @"\UpLoad");
            using (FileStream fileStream = System.IO.File.Create(filename))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }


            return Json(new
                { code = 0, msg = "上传成功", data = new { src = fileurl, title = "图片标题" } });
        }

    }
}