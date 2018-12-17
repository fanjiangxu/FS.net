using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderReturnMessage
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string OrderBillID { get; set; }

    [ColumnDescription("")]
    public string OrderID { get; set; }

    [ColumnDescription("")]
    public string Pictures { get; set; }

    [ColumnDescription("")]
    public int Reported { get; set; }

    [ColumnDescription("")]
    public int Restocking { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int SubmitQuality { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }
  }
}
