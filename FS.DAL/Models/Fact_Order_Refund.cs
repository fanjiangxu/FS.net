using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Fact_Order_Refund
  {

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int LanguageID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int Billid { get; set; }

    [ColumnDescription("")]
    public DateTime PayTime { get; set; }

    [ColumnDescription("")]
    public DateTime RefundDate { get; set; }

    [ColumnDescription("")]
    public string RefundReason { get; set; }

    [ColumnDescription("")]
    public int PingTai { get; set; }

    [ColumnDescription("")]
    public string RefundAmount { get; set; }

    [ColumnDescription("")]
    public int AdminID { get; set; }

    [ColumnDescription("")]
    public string DisputeReason { get; set; }

    [ColumnDescription("")]
    public DateTime DisputeDate { get; set; }

    [ColumnDescription("")]
    public DateTime CancelDate { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public string ProductNo { get; set; }

    [ColumnDescription("")]
    public int Refundon { get; set; }
  }
}
