using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Order_Dis
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public DateTime PayTime { get; set; }

    [ColumnDescription("")]
    public int IsDisputed { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime DisTime { get; set; }

    [ColumnDescription("")]
    public DateTime DisEndTime { get; set; }

    [ColumnDescription("")]
    public DateTime RefundTime { get; set; }

    [ColumnDescription("")]
    public string RefundReason { get; set; }

    [ColumnDescription("")]
    public string DisReason { get; set; }

    [ColumnDescription("")]
    public decimal RefundMoney { get; set; }

    [ColumnDescription("")]
    public decimal OrderMoney { get; set; }
  }
}
