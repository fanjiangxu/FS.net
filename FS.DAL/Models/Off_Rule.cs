using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Off_Rule
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public decimal PriceStart { get; set; }

    [ColumnDescription("")]
    public decimal PriceEnd { get; set; }

    [ColumnDescription("")]
    public decimal RandomStart { get; set; }

    [ColumnDescription("")]
    public decimal RandomEnd { get; set; }

    [ColumnDescription("")]
    public int CategoryID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }
  }
}
