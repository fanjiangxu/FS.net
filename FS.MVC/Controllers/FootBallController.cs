using FS.Common.Base;
using FS.Common.Helper;
using FS.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace FS.MVC.Controllers
{
    public class FootBallController : BaseController
    {
        // GET: FootBall
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string GetJsonResult()
        {
            var sql = "select Match_Bmdy,Match_Bhdy,Match_Bgdy,(Case when 类型='胜' then 1 when 类型='负' then -1 else 0 end) Match_ResultType from CollectionMaster_Data";
            var list=DapperHelper.GetList<FootBallViewModel>(sql);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[");
            for (var i = 0; i < list.Count; i++)
            {
                if (i > 0) sb.Append(",");
                sb.AppendLine("[" + list[i].Match_Bmdy + "," + list[i].Match_Bgdy +"]");
            }
            sb.AppendLine("]");
            return sb.ToString();
        }
    }
}