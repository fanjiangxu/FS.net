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
    public class SharesHelper
    {
        #region   当前持股
        public static int InsertCurrentShares(CurrentShares entity)
        {
            var result = ConfigHelper.GetConn().ExecuteScalar(
                "Insert into TB_CurrentShares values (@Name, @Code, @CurrentShare, "
                + "@CanUseShare, @CurrentPrice, @Increase, @BasePrice, @TotalMoney, @FloatingPL, @PLScale"
                + ", @ChiCangZB, @UserID,@UserName);select  @@IDENTITY;"
                ,entity);
            return Convert.ToInt32(result);
        }
        public static int DeleteCurrentShares(int ID)
        {
            var result = ConfigHelper.GetConn().Execute("Delete from TB_CurrentShares where ID=@ID",
                                   new { ID=ID });
            return result;
        }
        public static int UpdateCurrentShares(CurrentShares entity)
        {
            var result = ConfigHelper.GetConn().Execute("update TB_CurrentShares set Name=@Name, Code=@Code, CurrentShare=@CurrentShare, "
                + "CanUseShare=@CanUseShare, CurrentPrice=@CurrentPrice, Increase=@Increase, BasePrice=@BasePrice, TotalMoney=@TotalMoney, FloatingPL=@FloatingPL, PLScale=@PLScale"
                + ", ChiCangZB=@ChiCangZB, UserID=@UserID,UserName=@UserName where ID=@ID",
                                   entity);
            return result;
        }
        public static List<CurrentShares> GetCurrentSharesList()
        {
            List<CurrentShares> matchlist = new List<CurrentShares>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select * from TB_CurrentShares";
                matchlist = conn.Query<CurrentShares>(sqlCommandText).ToList();
            }
            return matchlist;
        }
        public static CurrentShares GetCurrentSharesByID(int ID)
        {
            List<CurrentShares> matchlist = new List<CurrentShares>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select * from TB_CurrentShares where ID=" + ID + "";
                matchlist = conn.Query<CurrentShares>(sqlCommandText).ToList();
            }
            return matchlist.Count != 0 ? matchlist.FirstOrDefault() : null;
        }
        #endregion

        #region   当日委托
        public static int InsertEntrustShares(EntrustShares entity)
        {
            var result = ConfigHelper.GetConn().ExecuteScalar("Insert into TB_EntrustShares values (@Name, @Code, @Type, "
                + "@Price, @Number, @CreateTime, @State, @UserID, @UserName);select  @@IDENTITY;",
                                  entity);
            return Convert.ToInt32(result);
        }
        public static int DeleteEntrustShares(int ID)
        {
            var result = ConfigHelper.GetConn().Execute("Delete from TB_EntrustShares where ID=@ID",
                                   new { ID = ID });
            return result;
        }
        public static int UpdateEntrustShares(EntrustShares entity)
        {
            var result = ConfigHelper.GetConn().Execute("update TB_EntrustShares set Name=@Name, Code=@Code,Type=@Type, "
                + "Price=@Price, Number=@Number, CreateTime=@CreateTime, State=@State, UserID=@UserID, UserName=@UserName where ID=@ID",
                                   entity);
            return result;
        }
        public static List<EntrustShares> GetEntrustSharesList()
        {
            List<EntrustShares> matchlist = new List<EntrustShares>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select * from TB_EntrustShares";
                matchlist = conn.Query<EntrustShares>(sqlCommandText).ToList();
            }
            return matchlist;
        }
        public static EntrustShares GetEntrustSharesByID(int ID)
        {
            List<EntrustShares> matchlist = new List<EntrustShares>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select * from TB_EntrustShares where ID=" + ID + "";
                matchlist = conn.Query<EntrustShares>(sqlCommandText).ToList();
            }
            return matchlist.Count != 0 ? matchlist.FirstOrDefault() : null;
        }
        #endregion

        #region   当日成交
        public static int InsertTurnoverShares(TurnoverShares entity)
        {
            var result = ConfigHelper.GetConn().ExecuteScalar("Insert into TB_TurnoverShares values (@Name, @Code, @Type, "
                + "@Price, @Number,@TotalPrice, @CreateTime, @UserID, @UserName);select  @@IDENTITY;",
                                  entity);
            return Convert.ToInt32(result);
        }
        public static int DeleteTurnoverShares(int ID)
        {
            var result = ConfigHelper.GetConn().Execute("Delete from TB_TurnoverShares where ID=@ID",
                                   new { ID = ID });
            return result;
        }
        public static int UpdateTurnoverShares(TurnoverShares entity)
        {
            var result = ConfigHelper.GetConn().Execute("update TB_TurnoverShares set Name=@Name, Code=@Code,Type=@Type, "
                + "Price=@Price, Number=@Number,TotalPrice=@TotalPrice, CreateTime=@CreateTime, UserID=@UserID, UserName=@UserName where ID=@ID",
                                   entity);
            return result;
        }
        public static List<TurnoverShares> GetTurnoverSharesList()
        {
            List<TurnoverShares> matchlist = new List<TurnoverShares>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select * from TB_TurnoverShares";
                matchlist = conn.Query<TurnoverShares>(sqlCommandText).ToList();
            }
            return matchlist;
        }
        public static TurnoverShares GetTurnoverSharesByID(int ID)
        {
            List<TurnoverShares> matchlist = new List<TurnoverShares>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select * from TB_TurnoverShares where ID=" + ID + "";
                matchlist = conn.Query<TurnoverShares>(sqlCommandText).ToList();
            }
            return matchlist.Count != 0 ? matchlist.FirstOrDefault() : null;
        }
        #endregion

        #region   历史成交
        public static int InsertHistoryShares(HistoryShares entity)
        {
            var result = ConfigHelper.GetConn().ExecuteScalar("Insert into TB_HistoryShares values (@Name, @Code, @Type, "
                + "@CurrentPrice, @BasePrice, @Number, @TotalMoney, @ShowYiZB, @Yingkui,@UserID,@UserName,@CreateDate);select  @@IDENTITY;",
                                  entity);
            return Convert.ToInt32(result);
        }
        public static int DeleteHistoryShares(int ID)
        {
            var result = ConfigHelper.GetConn().Execute("Delete from TB_HistoryShares where ID=@ID",
                                   new { ID = ID });
            return result;
        }
        public static int UpdateHistoryShares(HistoryShares entity)
        {
            var result = ConfigHelper.GetConn().Execute("update TB_HistoryShares set Name=@Name, Code=@Code,Type=@Type, "
                + "CurrentPrice=@CurrentPrice, BasePrice=@BasePrice, Number=@Number, TotalMoney=@TotalMoney, ShowYiZB=@ShowYiZB, Yingkui=@Yingkui,UserID=@UserID,UserName=@UserName where ID=@ID",
                                   entity);
            return result;
        }
        public static List<HistoryShares> GetHistorySharesList()
        {
            List<HistoryShares> matchlist = new List<HistoryShares>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select * from TB_HistoryShares";
                matchlist = conn.Query<HistoryShares>(sqlCommandText).ToList();
            }
            return matchlist;
        }
        public static HistoryShares GetHistorySharesByID(int ID)
        {
            List<HistoryShares> matchlist = new List<HistoryShares>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select * from TB_HistoryShares where ID=" + ID + "";
                matchlist = conn.Query<HistoryShares>(sqlCommandText).ToList();
            }
            return matchlist.Count != 0 ? matchlist.FirstOrDefault() : null;
        }
        #endregion
    }
}
