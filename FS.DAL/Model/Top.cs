using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DAL.Model
{
    public class Top
    {
        public int ID { get; set; }
        public int Sort { get; set; }
        public string UserName { get; set; }
        public decimal TotalMoney { get; set; }
        public decimal TotalProfit { get; set; }
        public decimal YesterdayProfit { get; set; }
        public decimal WeekProfit { get; set; }
        public decimal MonthProfit { get; set; }
        public decimal YearProfit { get; set; }
        public decimal SuccessRate { get; set; }
        public decimal TotalTurnover { get; set; }
        public decimal MonthTurnover { get; set; }
        public string Position { get; set; }
        public decimal MaxReturn { get; set; }
        public string StrDesc { get; set; }
        public string Level { get; set; }
        public DateTime UpdateTime { get; set; }
        public int MatchID { get; set; }
        public string UserURL { get; set; }
    }
}
