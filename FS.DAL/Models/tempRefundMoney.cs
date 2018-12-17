using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class tempRefundMoney
  {

    [ColumnDescription("")]
    public decimal RefundMoney { get; set; }

    [ColumnDescription("")]
    public decimal CurrencyRate { get; set; }

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public DateTime PayTime { get; set; }

    [ColumnDescription("")]
    public int Currency { get; set; }
  }
}
