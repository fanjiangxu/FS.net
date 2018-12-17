using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FS.Framework
{
    public  class PrivateWorkHelper
    {
   //     public static void test(UserMatchInfo item)
   //     {
   //         string url = "http://www.cofool.com/Home/User/tradeItem.html";
   //         string gid =item.Gid;
   //         string uid =item.Uid;
   //         string web_id =item.Web_id;
   //         string all_balance =item.All_balance;
   //         string archive = item.Archive;
   //         string type = item.Type;
   //         string result = "";
   //         string param = HttpUtility.UrlEncode("type") + "=" + HttpUtility.UrlEncode(type)
   //+ "&" + HttpUtility.UrlEncode("gid") + "=" + HttpUtility.UrlEncode(gid)
   // + "&" + HttpUtility.UrlEncode("uid") + "=" + HttpUtility.UrlEncode(uid)
   //  + "&" + HttpUtility.UrlEncode("web_id") + "=" + HttpUtility.UrlEncode(web_id)
   //   + "&" + HttpUtility.UrlEncode("web_id") + "=" + HttpUtility.UrlEncode(web_id)
   //    + "&" + HttpUtility.UrlEncode("all_balance") + "=" + HttpUtility.UrlEncode(all_balance)
   //      + "&" + HttpUtility.UrlEncode("archive") + "=" + HttpUtility.UrlEncode(archive);
   //         result += RemotePostHelper.HttpPostWebService(url, param);
   //         if (!result.Contains("暂无交易的数据"))
   //         {
   //             UserMatchInfoHelper.SetUserMatchInfoHtml(result,item.ID);
   //         }
   //         Console.WriteLine(result);
   //     }
        public static void HtmlTableToDataTable(string html)
        {

        }
    }
}
