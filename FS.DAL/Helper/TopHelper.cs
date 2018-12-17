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
    public class TopHelper
    {
        public static int InsertTop(Top entity)
        {
            var result = ConfigHelper.GetConn().ExecuteScalar("Insert into TB_Top values (@Sort, @UserName, @TotalMoney, "
                +"@TotalProfit, @YesterdayProfit, @WeekProfit, @MonthProfit, @YearProfit, @SuccessRate, @TotalTurnover"
                + ", @MonthTurnover, @Position,@MaxReturn,@StrDesc,@Level,@UpdateTime,@MatchID,@UserURL);select  @@IDENTITY;",
                                  entity);
            return Convert.ToInt32(result);
        }
        public static int DeleteTop(int ID)
        {
            var result = ConfigHelper.GetConn().Execute("Delete from TB_Top where ID=@ID",
                                   new { ID=ID });
            return result;
        }
        public static int UpdateTop(Top entity)
        {
            var result = ConfigHelper.GetConn().Execute("update TB_Top set Sort=@Sort, UserName=@UserName,UserURL=@UserURL, TotalMoney=@TotalMoney, "
                + "TotalProfit=@TotalProfit,YesterdayProfit= @YesterdayProfit, WeekProfit=@WeekProfit, MonthProfit=@MonthProfit, YearProfit=@YearProfit, SuccessRate=@SuccessRate, TotalTurnover=@TotalTurnover"
                + ", MonthTurnover=@MonthTurnover, Position=@Position,MaxReturn=@MaxReturn,StrDesc=@StrDesc,Level=@Level,UpdateTime=@UpdateTime where MatchID=@MatchID",
                                   entity);
            return result;
        }
        public static List<Top> GetTopList()
        {
            List<Top> matchlist = new List<Top>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select * from TB_Top";
                matchlist = conn.Query<Top>(sqlCommandText).ToList();
            }
            return matchlist;
        }
        public static Top GetTopByID(int ID)
        {
            List<Top> matchlist = new List<Top>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select * from TB_Top where ID=" + ID + "";
                matchlist = conn.Query<Top>(sqlCommandText).ToList();
            }
            return matchlist.Count != 0 ? matchlist.FirstOrDefault() : null;
        }
        public static int GetMaxTopID()
        {
            List<Top> matchlist = new List<Top>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select top 1 * from TB_Top order by ID desc";
                matchlist = conn.Query<Top>(sqlCommandText).ToList();
            }
            return matchlist.Count != 0 ? matchlist.FirstOrDefault().ID :0;
        }
    }
}
