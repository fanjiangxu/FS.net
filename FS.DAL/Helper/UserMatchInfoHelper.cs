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
    public class UserMatchInfoHelper
    {
        #region UserMatchInfo 用户参数信息
        public static int InsertUserMatchInfo(UserMatchInfo entity)
        {
            var result = ConfigHelper.GetConn().ExecuteScalar("Insert into TB_UserMatchInfo values (@Type, @Gid, @Uid, @Web_id, @Archive, @All_balance,@Html);select  @@IDENTITY;",
                                  entity);
            return Convert.ToInt32(result);
        }
        public static int DeleteUserMatchInfo(int ID)
        {
            var result = ConfigHelper.GetConn().Execute("Delete from TB_UserMatchInfo where ID=@ID",
                                   new { ID=ID });
            return result;
        }
        public static int UpdateUserMatchInfo(UserMatchInfo entity)
        {
            var result = ConfigHelper.GetConn().Execute("update TB_UserMatchInfo set Type=@Type, Gid=@Gid,Uid=@Uid, Web_id=@Web_id, "
                + "Archive=@Archive,All_balance= @All_balance where MatchID=@MatchID",
                                   entity);
            return result;
        }
        public static int SetUserMatchInfoHtml(string html,int id)
        {
            var result = ConfigHelper.GetConn().Execute("update TB_UserMatchInfo set Html='"+html+"' where ID="+ id + "");
            return result;
        }
        public static List<UserMatchInfo> GetUserMatchInfoList()
        {
            List<UserMatchInfo> matchlist = new List<UserMatchInfo>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select * from TB_UserMatchInfo";
                matchlist = conn.Query<UserMatchInfo>(sqlCommandText).ToList();
            }
            return matchlist;
        }
        public static UserMatchInfo GetUserMatchInfoByID(int ID)
        {
            List<UserMatchInfo> matchlist = new List<UserMatchInfo>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select * from TB_UserMatchInfo where ID=" + ID + "";
                matchlist = conn.Query<UserMatchInfo>(sqlCommandText).ToList();
            }
            return matchlist.Count != 0 ? matchlist.FirstOrDefault() : null;
        }

        public static UserMatchInfo GetUserMatchInfoTop1()
        {
            List<UserMatchInfo> matchlist = new List<UserMatchInfo>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select top 1 * from TB_UserMatchInfo where gid=16849 order by Id asc";
                matchlist = conn.Query<UserMatchInfo>(sqlCommandText).ToList();
            }
            return matchlist.Count != 0 ? matchlist.FirstOrDefault() : null;
        }
        #endregion

        #region HtmlTable 用户参数信息
        public static int InsertHtmlTable(HtmlTable entity)
        {
            var result = ConfigHelper.GetConn().ExecuteScalar("Insert into TB_HtmlTable values (@Type, @Gid, @Uid, @Web_id, @Archive, @All_balance);select  @@IDENTITY;",
                                  entity);
            return Convert.ToInt32(result);
        }
        public static int DeleteHtmlTable(int ID)
        {
            var result = ConfigHelper.GetConn().Execute("Delete from TB_HtmlTable where ID=@ID",
                                   new { ID = ID });
            return result;
        }
        public static int UpdateHtmlTable(HtmlTable entity)
        {
            var result = ConfigHelper.GetConn().Execute("update TB_HtmlTable set Type=@Type, Gid=@Gid,Uid=@Uid, Web_id=@Web_id, "
                + "Archive=@Archive,All_balance= @All_balance where MatchID=@MatchID",
                                   entity);
            return result;
        }
        public static List<HtmlTable> GetHtmlTableList()
        {
            List<HtmlTable> matchlist = new List<HtmlTable>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select top 1 * from TB_HtmlTable";
                matchlist = conn.Query<HtmlTable>(sqlCommandText).ToList();
            }
            return matchlist;
        }
        public static HtmlTable GetHtmlTableByID(int ID)
        {
            List<HtmlTable> matchlist = new List<HtmlTable>();
            using (IDbConnection conn = ConfigHelper.GetConn())
            {
                string sqlCommandText = @"select * from TB_HtmlTable where ID=" + ID + "";
                matchlist = conn.Query<HtmlTable>(sqlCommandText).ToList();
            }
            return matchlist.Count != 0 ? matchlist.FirstOrDefault() : null;
        }
        #endregion
    }
}
