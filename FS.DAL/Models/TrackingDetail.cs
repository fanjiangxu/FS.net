using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class TrackingDetail
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ShipNOID { get; set; }

    [ColumnDescription("")]
    public string ShipNO { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public string Location { get; set; }

    [ColumnDescription("")]
    public string Details { get; set; }

    [ColumnDescription("")]
    public DateTime InsertTime { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
