using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Active_OrderLog
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("订单id")]
    public int OrderID { get; set; }

    [ColumnDescription("参加的活动id")]
    public int ActiveID { get; set; }

    [ColumnDescription("备注")]
    public string Remark { get; set; }

    [ColumnDescription("减现的钱")]
    public decimal Price { get; set; }

    [ColumnDescription("减现的类型")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
