using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class HistoryShares
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string Code { get; set; }

    [ColumnDescription("")]
    public string Type { get; set; }

    [ColumnDescription("")]
    public decimal CurrentPrice { get; set; }

    [ColumnDescription("")]
    public decimal BasePrice { get; set; }

    [ColumnDescription("")]
    public int Number { get; set; }

    [ColumnDescription("")]
    public decimal TotalMoney { get; set; }

    [ColumnDescription("")]
    public string ShowYiZB { get; set; }

    [ColumnDescription("")]
    public string Yingkui { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string UserName { get; set; }

    [ColumnDescription("")]
    public DateTime CreateDate { get; set; }
  }
}
