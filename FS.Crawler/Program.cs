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
using System.Threading;

namespace FS.Crawler
{
    class Program
    {
        private readonly static string connString = ConfigurationSettings.AppSettings["ConnString"].ToString();

        static void Main(string[] args)
        {
            FootballMorningCrawler();
            Thread.Sleep(60000);
            //清洗数据
            ClearData();
            //Email发送结果
            SendReusltEmail();
            Console.WriteLine("执行完成！");
            return;
        }

        public static void SendReusltEmail()
        {
            EmailHelper.SendEmail();
        }

        /// 抓取早盘数据
        /// <summary>
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
                    Match_Recommend(json.DB);

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
                postUriData.PostString = "&p=" + i + "&oddpk=M&leg=";
                postUriDataList.Add(postUriData);
                postUriData.PostString = "&p=" + i + "&oddpk=I&leg=";
                postUriDataList.Add(postUriData);
                postUriData.PostString = "&p=" + i + "&oddpk=E&leg=";
                postUriDataList.Add(postUriData);


                PostUriData postUriData1 = new PostUriData();
                postUriData1.Uri = new Uri("https://7345v.com/index.php/sports/Match/FootballToday/?t=" + t);
                postUriData.PostString = "&p=" + i + "&oddpk=H&leg=";
                postUriDataList.Add(postUriData);
                postUriData.PostString = "&p=" + i + "&oddpk=M&leg=";
                postUriDataList.Add(postUriData);
                postUriData.PostString = "&p=" + i + "&oddpk=I&leg=";
                postUriDataList.Add(postUriData);
                postUriData.PostString = "&p=" + i + "&oddpk=E&leg=";
                postUriDataList.Add(postUriData);

                PostUriData postUriData2 = new PostUriData();
                postUriData2.Uri = new Uri("https://7345v.com/index.php/sports/Match/FBRresults/?t=" + t);
                postUriData2.PostString = "&time=" + i;
                postUriDataList.Add(postUriData2);
            }
            Parallel.ForEach(postUriDataList, new ParallelOptions { MaxDegreeOfParallelism = 3 }, (postUriData, pls, i) =>
            {
                footballMorningCrawler.StartPost(postUriData.Uri, postUriData.PostString);   //Post请求
            });
        }

        /// <summary>
        /// 筛选符合条件的
        /// </summary>
        /// <param name="list"></param>
        public static void Match_Recommend(List<FootballMorning> list)
        {
            var sql = @"select * from Match_Results";
            var list1 = DapperHelper.GetList<FootBallResult>(sql);
            foreach (var item in list)
            {
                var entity=list1.Where(m=>(m.Match_Bgdy==Convert.ToDecimal(item.Match_Bgdy)&& m.Match_Bmdy ==Convert.ToDecimal(item.Match_Bmdy))).FirstOrDefault();
                if (entity != null)
                {
                    string sql2 = string.Format("insert into Match_Recommend values('{0}','{1}','{2}','{3}','{4}',getdate(),{5})", item.Match_Master,item.Match_Guest,item.Match_Date.Replace("<br/>", " ").Replace("<br><font color=red>滾球</font>", ""), item.Match_Bmdy, item.Match_Bgdy,entity.Match_ResultType);
                    DapperHelper.Excute(sql2);
                }
            }
        }
        /// <summary>
        ///清洗数据
        /// </summary>
        public static void ClearData()
        {
            using (IDbConnection connection = new SqlConnection(connString))
            {
                var sql = @"
truncate  table FBRresults_ClearData;
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
      ,[TG_Inball];
----------------------------------------------------------------------------------------------   
truncate  table FootballMorning_ClearData;
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
      ,[Match_Bdxpk2];
----------------------------------------------------------------------------------------------     
truncate table FootballToday_ClearData;
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
      ,[Match_Bdxpk2]  ;
----------------------------------------------------------------------------------------------    刷比赛结果表（FBRresults_ClearData）的Match_ID
--
update r set r.Match_ID=m.Match_ID from dbo.FBRresults_ClearData r
inner join FootballMorning_ClearData m on r.Match_Master=m.Match_Master and r.Match_Guest=m.Match_Guest and m.Match_Name=r.Match_Name and m.Match_Date like '%'+r.Match_MatchTime+'%';
----------------------------------------------------------------------------------------------   汇总比赛结果
truncate  table CollectionMaster_Data;
insert into  CollectionMaster_Data
select r.Match_Name,r.Match_MatchTime,r.Match_Master,r.Match_Guest,r.MB_Inball '主',r.TG_Inball '客',m.Match_Bmdy,m.Match_Bgdy
,(case when MB_Inball>TG_Inball then '胜' when MB_Inball=TG_Inball then '平' else '负' end) '类型'
,10 '支出'
,(case when MB_Inball>TG_Inball then 10*CONVERT(decimal(18,2),m.Match_Bmdy) else -10 end)   '主场胜'
,(case when MB_Inball=TG_Inball then 10*CONVERT(decimal(18,2),m.Match_Bhdy) else -10 end)   '主场平'
,(case when MB_Inball<TG_Inball then 10*CONVERT(decimal(18,2),m.Match_Bgdy) else -10 end)   '主场负'
,(case when MB_Inball>TG_Inball then Convert(decimal(18,2),CONVERT(decimal(18,2),m.Match_Bmdy)/CONVERT(decimal(18,2),m.Match_Bgdy))
when MB_Inball<TG_Inball then Convert(decimal(18,2),CONVERT(decimal(18,2),m.Match_Bgdy)/CONVERT(decimal(18,2),m.Match_Bmdy)) 
else  m.Match_Bhdy end) '赔率比'
,m.Match_Bhdy
 from dbo.FBRresults_ClearData r
 left join FootballMorning_ClearData m on CONVERT(nvarchar(255),r.Match_ID)= CONVERT(nvarchar(255),m.Match_ID)
 where  CONVERT(nvarchar(255),m.Match_ID)>'0' and m.Match_Bgdy!='0' and r.Match_Master not like '%角球数%' and (r.MB_Inball!='-' and r.TG_Inball!='-')
 group by r.Match_Name,r.Match_MatchTime,r.Match_Master,r.Match_Guest,r.MB_Inball_HR,r.MB_Inball,r.TG_Inball_HR,r.TG_Inball,m.Match_Bmdy,m.Match_Bgdy,m.Match_Bhdy
 order by m.Match_Bmdy;

----------------------------------------------------------------------------------------------   汇总比赛结果 
truncate table MasterOddsWin_1_5
declare @intMin decimal(18,2),@intMax decimal(18,2);
set @intMin=1
set @intmax=6
while @intMin<=@intMax
begin
 insert into MasterOddsWin_1_5
 select (case when SUM(t.主场胜)-SUM(t.支出)>0 then SUM(t.主场胜)-SUM(t.支出) else -SUM(t.支出) end) '主胜_盈利',(case when SUM(t.主场平)-SUM(t.支出)>0 then SUM(t.主场平)-SUM(t.支出) else -SUM(t.支出) end) '平_盈利',(case when SUM(t.主场负)-SUM(t.支出)>0 then SUM(t.主场负)-SUM(t.支出) else -SUM(t.支出) end) '主负_盈利',SUM(t.支出) '本金','Match_Bgdy '+CONVERT(nvarchar(255),@intMin)+'--'+CONVERT(Nvarchar(255),@intMin+0.5) '类型'
 from  CollectionMaster_Data t 
 where Convert(decimal(18,2),Match_Bgdy)>@intMin and Convert(decimal(18,2),Match_Bgdy)<@intMin+0.5;
set @intMin=@intMin+0.5
end

set @intMin=1
set @intmax=6
while @intMin<=@intMax
begin
 insert into MasterOddsWin_1_5
 select (case when SUM(t.主场胜)-SUM(t.支出)>0 then SUM(t.主场胜)-SUM(t.支出) else -SUM(t.支出) end) '主胜_盈利',(case when SUM(t.主场平)-SUM(t.支出)>0 then SUM(t.主场平)-SUM(t.支出) else -SUM(t.支出) end) '平_盈利',(case when SUM(t.主场负)-SUM(t.支出)>0 then SUM(t.主场负)-SUM(t.支出) else -SUM(t.支出) end) '主负_盈利',SUM(t.支出) '本金','Match_Bmdy '+CONVERT(nvarchar(255),@intMin)+'--'+CONVERT(Nvarchar(255),@intMin+0.5) '类型'
 from  CollectionMaster_Data t 
 where Convert(decimal(18,2),Match_Bmdy)>@intMin and Convert(decimal(18,2),Match_Bmdy)<@intMin+0.5;
set @intMin=@intMin+0.5
end

set @intMin=1
set @intmax=6
while @intMin<=@intMax
begin
 insert into MasterOddsWin_1_5
 select (case when SUM(t.主场胜)-SUM(t.支出)>0 then SUM(t.主场胜)-SUM(t.支出) else -SUM(t.支出) end) '主胜_盈利',(case when SUM(t.主场平)-SUM(t.支出)>0 then SUM(t.主场平)-SUM(t.支出) else -SUM(t.支出) end) '平_盈利',(case when SUM(t.主场负)-SUM(t.支出)>0 then SUM(t.主场负)-SUM(t.支出) else -SUM(t.支出) end) '主负_盈利',SUM(t.支出) '本金','Match_Bhdy '+CONVERT(nvarchar(255),@intMin)+'--'+CONVERT(Nvarchar(255),@intMin+0.5) '类型'
 from  CollectionMaster_Data t 
 where Convert(decimal(18,2),Match_Bhdy)>@intMin and Convert(decimal(18,2),Match_Bhdy)<@intMin+0.5;
set @intMin=@intMin+0.5
end
----------------------------------------------------------------------------------------------   汇总比赛结果   赢的 没有不重复的 赔率记录
truncate table Match_Results
insert into Match_Results
select d1.Match_Bmdy,d1.Match_Bgdy,(Case when 类型='胜' then 1 when 类型='负' then -1 else 0 end) Match_ResultType
from CollectionMaster_Data d1
inner join
(
select Match_Bmdy,Match_Bgdy
  from CollectionMaster_Data 
group by Match_Bmdy,Match_Bgdy,类型 having(COUNT(Match_Bmdy))=1
)
d2
on d1.Match_Bmdy=d2.Match_Bmdy and d1.Match_Bgdy=d2.Match_Bgdy

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


