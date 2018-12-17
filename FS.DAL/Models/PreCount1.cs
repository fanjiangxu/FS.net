using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PreCount1
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public decimal price_preCount1 { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime Paytime { get; set; }

    [ColumnDescription("")]
    public decimal price_preCount1_11 { get; set; }
  }
}
