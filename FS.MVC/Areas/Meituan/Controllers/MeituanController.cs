using FS.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FS.MVC.Areas.Meituan.Controllers
{
    public class MeituanController : Controller
    {
        // GET: Meituan/Meituan
        public ActionResult Hongbao()
        {
            //var html=RemoteWebHelper.GetHtml("https://activity.waimai.meituan.com/coupon/sharechannel/B2EA8E1ABA8B47EA82DB475BA17B517D?urlKey=4C72DCF3E989419B9C8D3AF4B2DBA381&utm_term=AiphoneBwaimaiC6.7.1DweixinEwm-orderG7C09FF5CCB95A619AF037EE78FC50883FB6D2EF768119C6D913A849F59EF987820180716112437991&utm_source=appshare&utm_medium=iOSweb&utm_fromapp=wx&utm_sharesource=wm-order");
            //Response.Write(html);
            return View();
        }
    }
}