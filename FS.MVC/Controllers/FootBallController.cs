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

        /// <summary>
        /// 正常比例图
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// 胜负比例图
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetJsonResult1()
        {
            var sql = "select Match_Bmdy,Match_Bhdy,Match_Bgdy,(Case when 类型='胜' then 1 when 类型='负' then -1 else 0 end) Match_ResultType from CollectionMaster_Data";
            var list = DapperHelper.GetList<FootBallViewModel>(sql);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[");
            for (var i = 0; i < list.Count; i++)
            {
                if (i > 0) sb.Append(",");
                var type = list[i].Match_ResultType;
                switch (type)
                {
                    case 1:
                        sb.AppendLine("[" + list[i].Match_Bmdy + "," + -list[i].Match_Bgdy + "]");
                        break;
                    case -1:
                        sb.AppendLine("[" + -list[i].Match_Bmdy + "," + list[i].Match_Bgdy + "]");
                        break;
                    default:
                        sb.AppendLine("[" + -list[i].Match_Bmdy + "," + -list[i].Match_Bgdy + "]");
                        break;
                }
               
            }
            sb.AppendLine("]");
            return sb.ToString();
        }

        /// <summary>
        /// 排除三种重叠区域
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetJsonResult2()
        {
            var sql = @"select * from Match_Results";
            var list = DapperHelper.GetList<FootBallViewModel>(sql);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[");
            for (var i = 0; i < list.Count; i++)
            {
                if (i > 0) sb.Append(",");
                var type = list[i].Match_ResultType;
                switch (type)
                {
                    case 1:
                        sb.AppendLine("[" + list[i].Match_Bmdy + "," + -list[i].Match_Bgdy + "]");
                        break;
                    case -1:
                        sb.AppendLine("[" + -list[i].Match_Bmdy + "," + list[i].Match_Bgdy + "]");
                        break;
                    default:
                        sb.AppendLine("[" + -list[i].Match_Bmdy + "," + -list[i].Match_Bgdy + "]");
                        break;
                }

            }
            sb.AppendLine("]");
            return sb.ToString();
        }


        // GET: FootBall
        public ActionResult Index3D()
        {
            return View();
        }

        [HttpGet]
        public string GetJsonResult3D()
        {
            var sql = "select Match_Bmdy,Match_Bhdy,Match_Bgdy,(Case when 类型='胜' then 1 when 类型='负' then -1 else 0 end) Match_ResultType,类型 TypeName  from CollectionMaster_Data";
            var list = DapperHelper.GetList<FootBallViewModel>(sql);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[");
            for (var i = 0; i < list.Count; i++)
            {
                if (i > 0) sb.Append(",");
                sb.AppendLine("['" + list[i].TypeName + "','" + list[i].Match_ResultType + "'," + list[i].Match_Bmdy + "," + list[i].Match_Bhdy + "," + list[i].Match_Bgdy + ",1,2]");
            }
            sb.AppendLine("]");
            return sb.ToString();
        }
    }
}