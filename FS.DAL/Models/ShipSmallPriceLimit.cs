using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ShipSmallPriceLimit
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int ShipMethod { get; set; }

    [ColumnDescription("")]
    public string ShipMethodName { get; set; }

    [ColumnDescription("")]
    public int PmsCategoryID { get; set; }

    [ColumnDescription("")]
    public decimal MinPrice { get; set; }

    [ColumnDescription("")]
    public decimal MaxPrice { get; set; }
  }
}
