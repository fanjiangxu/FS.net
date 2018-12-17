using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderFast
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string TX { get; set; }

    [ColumnDescription("")]
    public decimal Weight { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public string BillIDs { get; set; }

    [ColumnDescription("")]
    public string CreateTime { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public string PayTime { get; set; }

    [ColumnDescription("")]
    public int PayType { get; set; }

    [ColumnDescription("")]
    public int FastType { get; set; }

    [ColumnDescription("")]
    public int RelationID { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
