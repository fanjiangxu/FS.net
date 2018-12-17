using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Logistics
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string LogisticsName { get; set; }

    [ColumnDescription("")]
    public string FuelSurcharge { get; set; }

    [ColumnDescription("")]
    public string Rate { get; set; }

    [ColumnDescription("")]
    public decimal Other { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
