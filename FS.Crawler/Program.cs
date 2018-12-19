using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using System.Net;
using FS.Crawler.Models;
using System.Web.Script.Serialization;
using Wesley.Crawler.SimpleCrawler.Models.Football;
using System.Data;
using System.Data.SqlClient;
using FS.Crawler.Common;
using Quartz;
using Quartz.Impl;
using FS.Crawler.Service;
using log4net;

namespace FS.Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballMorningCrawler();
            Console.ReadKey();
        }

        /// <summary>
        /// 抓取早盘数据
        /// </summary>
        public static void FootballMorningCrawler()
        {
            ILog loginfo = LogManager.GetLogger("logerror");
         
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var t="0."+Convert.ToInt64(ts.TotalSeconds).ToString();
            var footballMorningCrawler = new SimpleCrawler();//调用刚才写的爬虫程序
            footballMorningCrawler.OnStart += (s, e) =>
            {
                Console.WriteLine("爬虫开始抓取地址：" + e.Uri.ToString());
            };
            footballMorningCrawler.OnError += (s, e) =>
            {
                var error = "爬虫抓取出现错误：" + e.Uri.ToString() + "，异常消息：" + e.Exception.Message+"，时间："+DateTime.Now;
                Console.WriteLine(error);
                loginfo.Error(error);
            };
            footballMorningCrawler.OnCompleted += (s, e) =>
            {
                var url= e.Uri.AbsolutePath;
                JavaScriptSerializer Serializer = new JavaScriptSerializer();
                if (url.Contains("FBRresults"))
                {
                    JsonString json = Serializer.Deserialize<JsonString>(e.PageSource);
                    DapperHelper.InsertEntity<FBRresults>(json.DB);
                }
                if (url.Contains("FootballMorning"))
                {
                    JsonStringFootballMorning json = Serializer.Deserialize<JsonStringFootballMorning>(e.PageSource);
                    DapperHelper.InsertEntity<FootballMorning>(json.DB);
                }
                if (url.Contains("FootballToday"))
                {
                    JsonStringFootballToday json = Serializer.Deserialize<JsonStringFootballToday>(e.PageSource);
                    DapperHelper.InsertEntity<FootballToday>(json.DB);
                }
                Console.WriteLine(e.PageSource);
                Console.WriteLine("===============================================");
                Console.WriteLine("耗时：" + e.Milliseconds + "毫秒");
                Console.WriteLine("线程：" + e.ThreadId);
                Console.WriteLine("地址：" + e.Uri.ToString());
                loginfo.Error("===============================================");
                loginfo.Error("执行成功，地址：" + e.Uri.ToString() + "时间：" + DateTime.Now);
            };
       
            List<Uri> footballList = new List<Uri>();
            footballList.Add(new Uri("https://7345v.com/index.php/sports/Match/FootballMorning/?t=" + t));
            footballList.Add(new Uri("https://7345v.com/index.php/sports/Match/FootballToday/?t=" + t));
            footballList.Add(new Uri("https://7345v.com/index.php/sports/Match/FBRresults/?t=" + t));
            Parallel.For(0, footballList.Count, (i) =>
            {
                var football = footballList[i];
                footballMorningCrawler.Start(football);
            });
        }
    }
}


