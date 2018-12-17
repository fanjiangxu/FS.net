using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Order_DisputeRefund_Liubochen
  {

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public decimal Money { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }
  }
}
