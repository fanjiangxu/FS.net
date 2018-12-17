using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class TyingDiscount
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int TyingID { get; set; }

    [ColumnDescription("")]
    public int Count { get; set; }

    [ColumnDescription("")]
    public decimal Discount { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
