using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FS.DAL.Model;

namespace FS.DAL
{
    public class MatchHelper
    {
        public static int InsertMatch(Match entity)
        {
            var result = ConfigHelper.GetConn().ExecuteScalar("Insert into TB_Match values (@Name,@Num,@Rate,@CreateTime,@MatchID,@IntroduceUrl,@TopUrl);select  @@IDENTITY;", entity);
              //  ,new { Name=entity.Name,Num=entity.Num,Rate=entity.Rate,CreateTime=entity.CreateTime,MatchID=entity.MatchID, IntroduceUrl =entity.IntroduceUrl, TopUrl = entity.TopUrl });
            return Convert.ToInt32(result);
        }

        public static List<Match> GetMatchList()
        {
            List<Match> matchlist = new List<Match>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select top 5 * from TB_Match";
                matchlist = conn.Query<Match>(sqlCommandText).ToList();
            }
            return matchlist;
        }

        public static Match GetMatchByMatchID(int ID)
        {
            List<Match> matchlist = new List<Match>();
            using (IDbConnection conn = ConfigHelper.GetConn("server=.;uid=test;pwd=test;database=FS;Pooling=true;Max Pool Size=500;Min Pool Size=5"))
            {
                string sqlCommandText = @"select * from TB_Match where MatchID="+ID+"";
                matchlist = conn.Query<Match>(sqlCommandText).ToList();
            }
            return matchlist.Count!=0?matchlist.FirstOrDefault():null;
        }
        public static int GetMaxMatchID()
        {
            List<Match> matchlist = new List<Match>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select top 1 * from TB_Match order by matchID desc";
                matchlist = conn.Query<Match>(sqlCommandText).ToList();
            }
            return matchlist.Count != 0 ? matchlist.FirstOrDefault().MatchID :0;
        }
        public static int UpdateMatch(decimal baseMoney,DateTime startDate,DateTime endDate,int matchID)
        {
            var result = ConfigHelper.GetConn().Execute("update TB_Match set baseMoney=@baseMoney,  startDate=@startDate, endDate=@endDate where matchID=@matchID",
                                 new { baseMoney = baseMoney, startDate = startDate, endDate = endDate, matchID = matchID });
            return result;
        }
    }
}
