using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ShipMethod
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string CNName { get; set; }

    [ColumnDescription("")]
    public string ShipName { get; set; }

    [ColumnDescription("")]
    public int Logistics { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int IsShipping { get; set; }

    [ColumnDescription("")]
    public string StockingPeriod { get; set; }

    [ColumnDescription("")]
    public int sort { get; set; }
  }
}
