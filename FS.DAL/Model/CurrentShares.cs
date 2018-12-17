using FS.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DAL.Model
{
    public class CurrentShares
    {
        public int ID { get; set; }
        [ColumnDescription("")]
        public string Name { get; set; }
        public string Code { get; set; }
        /// <summary>
        /// 当前持股
        /// </summary>
        public int CurrentShare { get; set; }
        /// <summary>
        /// 当前可卖
        /// </summary>
        public int CanUseShare { get; set; }
        /// <summary>
        /// 当前价格
        /// </summary>
        public decimal CurrentPrice { get; set; }
        /// <summary>
        /// 涨幅
        /// </summary>
        public decimal Increase { get; set; }
        /// <summary>
        /// 购入价格
        /// </summary>
        public decimal BasePrice { get; set; }
        /// <summary>
        /// 总市值
        /// </summary>
        public decimal TotalMoney { get; set; }
        /// <summary>
        /// 浮动盈亏
        /// </summary>
        public decimal FloatingPL { get; set; }
        /// <summary>
        /// 盈亏比例
        /// </summary>
        public decimal PLScale { get; set; }
        /// <summary>
        ///持仓占比
        /// </summary>
        public decimal ChiCangZB { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
    }

    public class EntrustShares
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        /// <summary>
        /// 买入 卖出
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 委托价格价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 当前价格
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 委托状态
        /// </summary>
        public string State { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
    }

    public class TurnoverShares
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        /// <summary>
        /// 买入 卖出
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 委托价格价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 当前价格
        /// </summary>
        public int Number { get; set; }
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 委托状态
        /// </summary>
        public int UserID { get; set; }
        public string UserName { get; set; }
    }

    public class HistoryShares
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        /// <summary>
        /// 买入 卖出
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 当前价格
        /// </summary>
        public decimal CurrentPrice { get; set; }
        /// <summary>
        /// 购入价格
        /// </summary>
        public decimal BasePrice { get; set; }
        public int Number { get; set; }
        /// <summary>
        /// 总市值
        /// </summary>
        public decimal TotalMoney { get; set; }
        /// <summary>
        /// 浮动盈亏
        /// </summary>
        public string ShowYiZB { get; set; }
        /// <summary>
        /// 盈亏比例
        /// </summary>
        public string Yingkui { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public DateTime CreateDate { get; set;}
    }
}
