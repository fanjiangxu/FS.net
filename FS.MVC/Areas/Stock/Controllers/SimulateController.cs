using FS.BLL;
using FS.DAL;
using FS.DAL.Model;
using FS.Framework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FS.MVC.Areas.Stock.Controllers
{
    public class SimulateController : Controller
    {
        // GET: Stock/Simulate
        #region  刷比赛列表数据
        public ActionResult Index(string url="")
        {
            var pageIndex = 1;
            pageIndex = Request["pageIndex"]!=null?Convert.ToInt32(Request["pageIndex"]):1;
            var categoryID = 1;
            categoryID = Request["categoryID"] != null ? Convert.ToInt32(Request["categoryID"]) : 1;
            if (string.IsNullOrEmpty(url))
            {
                pageIndex = 1;
                categoryID = 1;
                url = "http://www.cofool.com/Group/more/category/" + categoryID;
            }
            if (pageIndex + 1 > 30)
            {
                pageIndex =0;
                categoryID++;
            }
            ViewBag.NextPageIndex = pageIndex+1;
         
            ViewBag.CategoryID = categoryID;
            //    url = url.Replace("&pageIndex="+ pageIndex, "");
            var html = RemoteWebHelper.GetHtml(url);
            Response.Write(html);
            return View();
        }
        [HttpPost]
        public void SaveMatch()
        {
           var json= Request["data"]!=null? Request["data"].ToString():"";
            var matchList=JsonHelper.DeserializeJsonToList<Match>(json);
            try
            {
                foreach (var item in matchList)
                {
                    if (MatchService.InsertMatch(item)==0)
                    {
                        RedirectToAction("Introduce");
                    }
                }
                Response.Write("ok");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        #endregion

        #region 刷比赛介绍  开始时间结束时间之类的
        public ActionResult Introduce(int matchID = 1)
        {
            var item = MatchService.GetMatchByMatchID(matchID);
            if (item == null)
            {
                return RedirectToAction("Introduce","Simulate",new { matchID=matchID+1});
            }
            var html = RemoteWebHelper.GetHtml(item.IntroduceUrl);
            Response.Write(html);
            ViewBag.NextMatchID = matchID + 1;
            return View();
        }
        public ActionResult ShowIntroduce(string url)
        {
            var html = RemoteWebHelper.GetHtml(url);
            Response.Write(html);
            return View();
        }
        #endregion
        [HttpPost]
        public void SaveMatchVliadDay()
        {
            var baseMoney = Request["baseMoney"] != null ? Convert.ToDecimal(Request["baseMoney"]) :0;
            var startDate = Request["startDate"] != null ? Convert.ToDateTime(Request["startDate"]) : DateTime.MinValue;
            DateTime endtime;
            var endDate = Request["endDate"] != null&&DateTime.TryParse(Request["endDate"],out endtime) ? Convert.ToDateTime(Request["endDate"]) : DateTime.MaxValue;
            var matchID = Request["matchID"] != null ? Convert.ToInt32(Request["matchID"]) : 0;
            try
            {
                var entity=MatchService.GetMatchByMatchID(matchID);
                if (entity.BaseMoney > 0)
                {
                    RedirectToAction("Top");
                }
                MatchService.UpdateMatch(baseMoney, startDate, endDate, matchID);
                Response.Write("ok");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        #region  获取比赛排名用户信息
        public ActionResult Top(int matchID = 1)
        {
            if (matchID == 1|| matchID == 0)
            {
                matchID = MatchService.GetMaxMatchID();
            }
            var item = MatchService.GetMatchByMatchID(matchID);
            if (item != null)
            {
                var html = RemoteWebHelper.GetHtml(item.TopUrl);
                Response.Write(html);
            }
            else
            {
                return RedirectToAction("Top", "Simulate", new { matchID = matchID - 1 });
            }
            ViewBag.NextMatchID = matchID-1;
            return View();
        }
        [HttpPost]
        public void SaveTop()
        {
            var json = Request["data"] != null ? Request["data"].ToString() : "";
            try
            {
                var topList = JsonHelper.DeserializeJsonToList<Top>(json);
                foreach (var item in topList)
                {
                    MatchService.InsertTop(item);
                }
                Response.Write("ok");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        #endregion

        #region 用户当前持仓
        public ActionResult Shares(int topID = 1)
        {
            var item = MatchService.GetTopByID(topID);
            if (item == null)
            {
                return RedirectToAction("Shares", "Simulate", new { topID = topID+1 });
            }
//            var html = RemoteWebHelper.GetHtml(item.UserURL);
//            html = html.Replace("http://static.cofool.com/public/js/stock.js?_=20170123", "http://en.www.cofool.com/Areas/Stock/JS/stock.js");//.Replace("http://static.cofool.com/public/js/jquery-1.8.2.min.js","");
//            var js = "<script src=\"http://en.www.cofool.com/Scripts/jquery-1.10.2.min.js\"></script>"
//                      + "<script>"
//    + "$(function() {"
//                + "document.domain = \"cofool.com\";"
//            + "});"
//+ "</script> ";
//            Response.Write(js);
//            Response.Write(html);
            ViewBag.UserID = item.UserURL.Replace("http://www.cofool.com/Home/User/index/uid/","").Replace("/gid/"+item.MatchID+".html", "");
            ViewBag.NextTopID = topID + 1;
            return View();
        }
        [HttpPost]
        public void SaveShares()
        {
            var json = Request["data"] != null ? Request["data"].ToString() : "";
            try
            {
                var topList = JsonHelper.DeserializeJsonToList<CurrentShares>(json);
                foreach (var item in topList)
                {
                    MatchService.InsertCurrentShares(item);
                }
                Response.Write("ok");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        #endregion

        #region 采集用户post请求所需的参数
        public ActionResult UserMatchInfo(int ID=1)
        {
            if (ID == 1)
            {
                ID = MatchService.GetMaxTopID();
            }
            var item = MatchService.GetTopByID(ID);
           // item.UserURL = "http://www.cofool.com/Home/User/index/uid/4971723/gid/16849.html";
            var html = RemoteWebHelper.GetHtml(item.UserURL);
            Response.Write(html);
            ViewBag.NextID = ID-1;
            return View();
        }
        [HttpPost]
        public void SaveUserMatchInfo()
        {
            var json = Request["data"] != null ? Request["data"].ToString() : "";
            try
            {
                var topList = JsonHelper.DeserializeJsonToList<UserMatchInfo>(json);
                foreach (var item in topList)
                {
                    MatchService.InsertUserMatchInfo(item);
                }
                Response.Write("ok");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        #endregion

        #region 用户持仓 tablehHtml
        public ActionResult AllShares(int topID = 1)
        {
            UserMatchInfo item;
            if (topID == 1)
            {
                item = MatchService.GetUserMatchInfoTop1();
                topID = item.ID;
            }
            else
            {
                item = MatchService.GetUserMatchInfoByID(topID);
            }
            if (item == null)
            {
                return RedirectToAction("AllShares", "Simulate", new { topID = topID + 1 });
            }

            string url = "http://www.cofool.com/Home/User/tradeItem.html";
            string gid = item.Gid;
            string uid = item.Uid;
            string web_id = item.Web_id;
            string all_balance = item.All_balance;
            string archive = item.Archive;
            string type = item.Type;
            string result = "";
            string param = HttpUtility.UrlEncode("type") + "=" + HttpUtility.UrlEncode(type)
   + "&" + HttpUtility.UrlEncode("gid") + "=" + HttpUtility.UrlEncode(gid)
    + "&" + HttpUtility.UrlEncode("uid") + "=" + HttpUtility.UrlEncode(uid)
     + "&" + HttpUtility.UrlEncode("web_id") + "=" + HttpUtility.UrlEncode(web_id)
      + "&" + HttpUtility.UrlEncode("web_id") + "=" + HttpUtility.UrlEncode(web_id)
       + "&" + HttpUtility.UrlEncode("all_balance") + "=" + HttpUtility.UrlEncode(all_balance)
         + "&" + HttpUtility.UrlEncode("archive") + "=" + HttpUtility.UrlEncode(archive);
            result += RemotePostHelper.HttpPostWebService(url, param);
            if (result.Contains("暂无交易的数据"))
            {
                return RedirectToAction("AllShares", "Simulate", new { topID = topID + 1 });
            }
            ViewBag.Html = result;
            ViewBag.Type = item.Type;
            ViewBag.UserID = uid.Replace(gid,"").Replace("X","");
            ViewBag.NextTopID = topID + 1;
            return View();
        }
        [HttpPost]
        public void SaveAllShares()
        {
            var json = Request["data"] != null ? Request["data"].ToString() : "";
            try
            {
                var topList = JsonHelper.DeserializeJsonToList<CurrentShares>(json);
                foreach (var item in topList)
                {
                    MatchService.InsertCurrentShares(item);
                }
                Response.Write("ok");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        [HttpPost]
        public void SaveEntrustShares()
        {
            var json = Request["data"] != null ? Request["data"].ToString() : "";
            try
            {
                var topList = JsonHelper.DeserializeJsonToList<EntrustShares>(json);
                foreach (var item in topList)
                {
                    MatchService.InsertEntrustShares(item);
                }
                Response.Write("ok");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        [HttpPost]
        public void SaveTurnoverShares()
        {
            var json = Request["data"] != null ? Request["data"].ToString() : "";
            try
            {
                var topList = JsonHelper.DeserializeJsonToList<TurnoverShares>(json);
                foreach (var item in topList)
                {
                    MatchService.InsertTurnoverShares(item);
                }
                Response.Write("ok");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        [HttpPost]
        public void SaveHistoryShares()
        {
            var json = Request["data"] != null ? Request["data"].ToString() : "";
            try
            {
                var topList = JsonHelper.DeserializeJsonToList<HistoryShares>(json);
                foreach (var item in topList)
                {
                    MatchService.InsertHistoryShares(item);
                }
                Response.Write("ok");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        #endregion
    }
}