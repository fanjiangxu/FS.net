using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Top
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public string UserName { get; set; }

    [ColumnDescription("")]
    public decimal TotalMoney { get; set; }

    [ColumnDescription("")]
    public decimal TotalProfit { get; set; }

    [ColumnDescription("")]
    public decimal YesterdayProfit { get; set; }

    [ColumnDescription("")]
    public decimal WeekProfit { get; set; }

    [ColumnDescription("")]
    public decimal MonthProfit { get; set; }

    [ColumnDescription("")]
    public decimal YearProfit { get; set; }

    [ColumnDescription("")]
    public decimal SuccessRate { get; set; }

    [ColumnDescription("")]
    public decimal TotalTurnover { get; set; }

    [ColumnDescription("")]
    public decimal MonthTurnover { get; set; }

    [ColumnDescription("")]
    public string Position { get; set; }

    [ColumnDescription("")]
    public decimal MaxReturn { get; set; }

    [ColumnDescription("")]
    public string StrDesc { get; set; }

    [ColumnDescription("")]
    public string Level { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public int MatchID { get; set; }

    [ColumnDescription("")]
    public string UserURL { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }
  }
}
