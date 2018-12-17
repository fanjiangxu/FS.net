using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ShipDiscount
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("0是默认;")]
    public int CountryID { get; set; }

    [ColumnDescription("")]
    public int ShipID { get; set; }

    [ColumnDescription("折扣系数")]
    public decimal Discount { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
