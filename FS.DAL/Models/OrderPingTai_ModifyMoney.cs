using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderPingTai_ModifyMoney
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int ResonID { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int AddUser { get; set; }

    [ColumnDescription("")]
    public decimal Money { get; set; }

    [ColumnDescription("")]
    public decimal OldMoney { get; set; }

    [ColumnDescription("")]
    public string ParentID { get; set; }

    [ColumnDescription("")]
    public string LogData { get; set; }
  }
}
