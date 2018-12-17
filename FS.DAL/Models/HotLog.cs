using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class HotLog
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int HotState { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int OrderBillID { get; set; }

    [ColumnDescription("")]
    public int HotStateID { get; set; }

    [ColumnDescription("")]
    public int AdminID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public DateTime HandleTime { get; set; }

    [ColumnDescription("")]
    public int IsSend { get; set; }

    [ColumnDescription("")]
    public DateTime SendTime { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }
  }
}
