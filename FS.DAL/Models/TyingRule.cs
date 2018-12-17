using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class TyingRule
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public string CategoryIDs { get; set; }

    [ColumnDescription("")]
    public int TyingID { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int Position { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public decimal Discount { get; set; }
  }
}
