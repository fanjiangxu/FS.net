using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Order_TuoTouAndDutyFree
  {

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public decimal TuoTouAndDutyFreeMoney { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public decimal DutyFreeCurr { get; set; }
  }
}
