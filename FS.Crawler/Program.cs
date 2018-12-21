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
using FS.Crawler.Models.Football;
using Dapper;
using System.Configuration;

namespace FS.Crawler
{
    class Program
    {
        private readonly static string connString = ConfigurationSettings.AppSettings["ConnString"].ToString();

        static void Main(string[] args)
        {
            FootballMorningCrawler();
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

            List<PostUriData> postUriDataList = new List<PostUriData>();
         
            for (var i = 1; i < 10; i++)
            {
                PostUriData postUriData = new PostUriData();
                postUriData.Uri = new Uri("https://7345v.com/index.php/sports/Match/FootballMorning/?t=" + t);
                postUriData.PostString = "&p=" + i + "&oddpk=H&leg=";
                postUriDataList.Add(postUriData);

                PostUriData postUriData1 = new PostUriData();
                postUriData1.Uri = new Uri("https://7345v.com/index.php/sports/Match/FootballToday/?t=" + t);
                postUriData1.PostString = "&p=" + i + "&oddpk=H&leg=";
                postUriDataList.Add(postUriData1);

                PostUriData postUriData2 = new PostUriData();
                postUriData2.Uri = new Uri("https://7345v.com/index.php/sports/Match/FBRresults/?t=" + t);
                postUriData2.PostString = "&time=" + i;
                postUriDataList.Add(postUriData2);
            }
            Parallel.ForEach(postUriDataList, new ParallelOptions { MaxDegreeOfParallelism = 3 }, (postUriData, pls, i) =>
            {
                footballMorningCrawler.StartPost(postUriData.Uri, postUriData.PostString);   //Post请求
            });

            //清洗数据
            using (IDbConnection connection = new SqlConnection(connString))
            {
                var sql = @"
truncate  table FBRresults_ClearData
insert into FBRresults_ClearData
select 
[Match_Name]
      ,[Match_MatchTime]
      ,[Match_Master]
      ,[Match_Guest]
      ,[MB_Inball_HR]
      ,[MB_Inball]
      ,[TG_Inball_HR]
      ,[TG_Inball]
      ,0
      from FBRresults group by [Match_Name]
      ,[Match_MatchTime]
      ,[Match_Master]
      ,[Match_Guest]
      ,[MB_Inball_HR]
      ,[MB_Inball]
      ,[TG_Inball_HR]
      ,[TG_Inball]
----------------------------------------------------------------------------------------------   
truncate  table FootballMorning_ClearData
insert into FootballMorning_ClearData
SELECT [Match_ID]
      ,[Match_Master]
      ,[Match_Guest]
      ,[Match_Name]
      ,REPLACE(REPLACE(Match_Date,'<br><font color=red>滾球</font>',''),'<br/>',' ')
      ,[Match_BzM]
      ,[Match_Ho]
      ,[Match_DxDpl]
      ,[Match_DsDpl]
      ,[Match_BzG]
      ,[Match_Ao]
      ,[Match_DxXpl]
      ,[Match_DsSpl]
      ,[Match_BzH]
      ,[Match_RGG]
      ,[Match_DxGG1]
      ,[Match_ShowType]
      ,[Match_DxGG2]
      ,[Match_Bmdy]
      ,[Match_BHo]
      ,[Match_Bdpl]
      ,[Match_Bgdy]
      ,[Match_BAo]
      ,[Match_Bxpl]
      ,[Match_Bhdy]
      ,[Match_BRpk]
      ,[Match_Bdxpk1]
      ,[Match_Hr_ShowType]
      ,[Match_Bdxpk2]
      ,GETDATE()
  FROM [FootballMorning]
  group by [Match_ID]
      ,[Match_Master]
      ,[Match_Guest]
      ,[Match_Name]
      ,REPLACE(REPLACE(Match_Date,'<br><font color=red>滾球</font>',''),'<br/>',' ')
      ,[Match_BzM]
      ,[Match_Ho]
      ,[Match_DxDpl]
      ,[Match_DsDpl]
      ,[Match_BzG]
      ,[Match_Ao]
      ,[Match_DxXpl]
      ,[Match_DsSpl]
      ,[Match_BzH]
      ,[Match_RGG]
      ,[Match_DxGG1]
      ,[Match_ShowType]
      ,[Match_DxGG2]
      ,[Match_Bmdy]
      ,[Match_BHo]
      ,[Match_Bdpl]
      ,[Match_Bgdy]
      ,[Match_BAo]
      ,[Match_Bxpl]
      ,[Match_Bhdy]
      ,[Match_BRpk]
      ,[Match_Bdxpk1]
      ,[Match_Hr_ShowType]
      ,[Match_Bdxpk2]
----------------------------------------------------------------------------------------------     
truncate table FootballToday_ClearData
insert into FootballToday_ClearData
SELECT [Match_ID]
      ,[SMM]
      ,[Match_Master]
      ,[Match_Guest]
      ,[Match_Name]
      ,REPLACE(REPLACE(Match_Date,'<br><font color=red>滾球</font>',''),'<br/>',' ')
      ,[Match_BzM]
      ,[Match_Ho]
      ,[Match_DxDpl]
      ,[Match_DsDpl]
      ,[Match_BzG]
      ,[Match_Ao]
      ,[Match_DxXpl]
      ,[Match_DsSpl]
      ,[Match_BzH]
      ,[Match_RGG]
      ,[Match_DxGG1]
      ,[Match_ShowType]
      ,[Match_DxGG2]
      ,[Match_Bmdy]
      ,[Match_BHo]
      ,[Match_Bdpl]
      ,[Match_Bgdy]
      ,[Match_BAo]
      ,[Match_Bxpl]
      ,[Match_Bhdy]
      ,[Match_BRpk]
      ,[Match_Bdxpk1]
      ,[Match_Hr_ShowType]
      ,[Match_Bdxpk2]
  FROM [FS].[dbo].[FootballToday]
  group by 
  [Match_ID]
      ,[SMM]
      ,[Match_Master]
      ,[Match_Guest]
      ,[Match_Name]
      ,REPLACE(REPLACE(Match_Date,'<br><font color=red>滾球</font>',''),'<br/>',' ')
      ,[Match_BzM]
      ,[Match_Ho]
      ,[Match_DxDpl]
      ,[Match_DsDpl]
      ,[Match_BzG]
      ,[Match_Ao]
      ,[Match_DxXpl]
      ,[Match_DsSpl]
      ,[Match_BzH]
      ,[Match_RGG]
      ,[Match_DxGG1]
      ,[Match_ShowType]
      ,[Match_DxGG2]
      ,[Match_Bmdy]
      ,[Match_BHo]
      ,[Match_Bdpl]
      ,[Match_Bgdy]
      ,[Match_BAo]
      ,[Match_Bxpl]
      ,[Match_Bhdy]
      ,[Match_BRpk]
      ,[Match_Bdxpk1]
      ,[Match_Hr_ShowType]
      ,[Match_Bdxpk2]  
----------------------------------------------------------------------------------------------   
               ";
                try
                {
                    connection.Execute(sql);
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}


