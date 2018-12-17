using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Option
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string ShowName { get; set; }

    [ColumnDescription("")]
    public string ElementName { get; set; }

    [ColumnDescription("")]
    public int Custom { get; set; }

    [ColumnDescription("")]
    public string Description { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public decimal CustomPrice { get; set; }

    [ColumnDescription("")]
    public string OptionValIDs { get; set; }

    [ColumnDescription("")]
    public string ProductIDs { get; set; }

    [ColumnDescription("")]
    public string CustomProductPrices { get; set; }

    [ColumnDescription("")]
    public string FrName { get; set; }

    [ColumnDescription("")]
    public string EsName { get; set; }

    [ColumnDescription("")]
    public string JpName { get; set; }

    [ColumnDescription("")]
    public int state { get; set; }
  }
}
