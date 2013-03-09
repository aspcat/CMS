﻿using System;
using System.Web.Mvc;
using AtomLab.Utility;
using YangKai.BlogEngine.Common;
using YangKai.BlogEngine.Modules.BoardModule.Events;
using YangKai.BlogEngine.Modules.BoardModule.Objects;
using YangKai.BlogEngine.ServiceProxy;
using YangKai.BlogEngine.Web.Mvc.Models;

namespace YangKai.BlogEngine.Web.Mvc.Controllers
{
    public class BoardController : Controller
    {
        //
        // 留言页面
        // GET: /board
        [ActionName("index")]
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Index()
        {
            var cookie = WebGuestCookie.Load();
            var viewModel = new BoardViewModel { Author = cookie.Name };
            return View(viewModel);
        }

        [ActionName("list")]
        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult List()
        {
            var data = QueryFactory.Board.FindAll(Int32.MaxValue);
            return Json(data.ToBoardViewModels(), JsonRequestBehavior.AllowGet);
        }

        //
        // 新增留言
        [ActionName("add")]
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult Add(BoardViewModel viewModel)
        {
            var entity = viewModel.ToBoardEntity();
            entity.Ip = Request.UserHostAddress;
            entity.Address = IpLocator.GetIpLocation(entity.Ip);

            try
            {
                CommandFactory.CreateBoard(entity);
                return Json(new { result = true, model = entity.ToBoardViewModel() });
            }
            catch (Exception e)
            {
                return Json(new {result = false, reason = e.Message});
            }
        }

        //
        // 删除留言
        [ActionName("delete")]
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult Delete(Guid id)
        {
            try
            {
                CommandFactory.Run(new BoardDeleteEvent() { BoardId = id });
                return Json(new {result = true});
            }
            catch (Exception e)
            {
                return Json(new {result = false, reason = e.Message});
            }
        }

        //
        // 最新留言页面
        [ActionName("recentmessages")]
        [AcceptVerbs(HttpVerbs.Get)]
        [ChildActionOnly]
        [OutputCache(Duration = 300)]
        public PartialViewResult RecentMessages()
        {
            return PartialView(QueryFactory.Board.FindAll(10));
        }
    }
}