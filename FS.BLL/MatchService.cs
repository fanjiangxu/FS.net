using FS.DAL;
using FS.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.BLL
{
    public class MatchService
    {
        public static int InsertMatch(Match entity)
        {
            int res = 0;
            if (MatchHelper.GetMatchByMatchID(entity.MatchID) == null)
            {
                return MatchHelper.InsertMatch(entity);
            }
            return res;
        }
        public static List<Match> GetMatchList()
        {
            return MatchHelper.GetMatchList();
        }
        public static Match GetMatchByMatchID(int matchID)
        {
            return MatchHelper.GetMatchByMatchID(matchID);
        }
        public static int GetMaxMatchID()
        {
            return MatchHelper.GetMaxMatchID();
        }
        
        public static int UpdateMatch(decimal baseMoney, DateTime startDate, DateTime endDate, int matchID)
        {
            return MatchHelper.UpdateMatch(baseMoney,  startDate, endDate,  matchID);
        }
        #region Top 排名
        public static int InsertTop(Top entity)
        {
            return TopHelper.InsertTop(entity);
        }
        public static int UpdateTop(Top entity)
        {
            return TopHelper.UpdateTop(entity);
        }
        public static Top GetTopByID(int topID)
        {
            return TopHelper.GetTopByID(topID);
        }
        public static int GetMaxTopID()
        {
            return TopHelper.GetMaxTopID();
        }
        #endregion

        #region User 当前持股
        public static int InsertCurrentShares(CurrentShares entity)
        {
            return SharesHelper.InsertCurrentShares(entity);
        }
        public static int UpdateCurrentShares(CurrentShares entity)
        {
            return SharesHelper.UpdateCurrentShares(entity);
        }
        public static CurrentShares GetCurrentSharesByID(int CurrentSharesID)
        {
            return SharesHelper.GetCurrentSharesByID(CurrentSharesID);
        }
        #endregion

        #region User 当日委托
        public static int InsertEntrustShares(EntrustShares entity)
        {
            return SharesHelper.InsertEntrustShares(entity);
        }
        public static int UpdateEntrustShares(EntrustShares entity)
        {
            return SharesHelper.UpdateEntrustShares(entity);
        }
        public static EntrustShares GetEntrustSharesByID(int EntrustSharesID)
        {
            return SharesHelper.GetEntrustSharesByID(EntrustSharesID);
        }
        #endregion

        #region User 当日成交
        public static int InsertTurnoverShares(TurnoverShares entity)
        {
            return SharesHelper.InsertTurnoverShares(entity);
        }
        public static int UpdateTurnoverShares(TurnoverShares entity)
        {
            return SharesHelper.UpdateTurnoverShares(entity);
        }
        public static TurnoverShares GetTurnoverSharesByID(int TurnoverSharesID)
        {
            return SharesHelper.GetTurnoverSharesByID(TurnoverSharesID);
        }
        #endregion

        #region User 历史持股
        public static int InsertHistoryShares(HistoryShares entity)
        {
            return SharesHelper.InsertHistoryShares(entity);
        }
        public static int UpdateHistoryShares(HistoryShares entity)
        {
            return SharesHelper.UpdateHistoryShares(entity);
        }
        public static HistoryShares GetHistorySharesByID(int HistorySharesID)
        {
            return SharesHelper.GetHistorySharesByID(HistorySharesID);
        }
        #endregion

        #region UserMatchInfo 用于采集用户持股信息
        public static int InsertUserMatchInfo(UserMatchInfo entity)
        {
            return UserMatchInfoHelper.InsertUserMatchInfo(entity);
        }
        public static int UpdateUserMatchInfo(UserMatchInfo entity)
        {
            return UserMatchInfoHelper.UpdateUserMatchInfo(entity);
        }
        public static UserMatchInfo GetUserMatchInfoByID(int UserMatchInfoID)
        {
            return UserMatchInfoHelper.GetUserMatchInfoByID(UserMatchInfoID);
        }
        public static UserMatchInfo GetUserMatchInfoTop1()
        {
            return UserMatchInfoHelper.GetUserMatchInfoTop1();
        }
        #endregion

    }
}
