using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ZoneShipping
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int Zone { get; set; }

    [ColumnDescription("")]
    public decimal ZonePrice { get; set; }

    [ColumnDescription("")]
    public string ZoneType { get; set; }

    [ColumnDescription("")]
    public string CategoryIDs { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string ShippingCost { get; set; }
  }
}
