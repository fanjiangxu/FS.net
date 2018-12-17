using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class City_KeyWord
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string KeyWord { get; set; }

    [ColumnDescription("")]
    public decimal Competition { get; set; }

    [ColumnDescription("")]
    public int Search { get; set; }

    [ColumnDescription("")]
    public int CountryID { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int City { get; set; }

    [ColumnDescription("")]
    public int IsShow { get; set; }

    [ColumnDescription("")]
    public int ProductCount { get; set; }

    [ColumnDescription("")]
    public string SaleProductID { get; set; }

    [ColumnDescription("")]
    public int LineID { get; set; }

    [ColumnDescription("")]
    public string MeteTitle { get; set; }

    [ColumnDescription("")]
    public string MeteDescription { get; set; }

    [ColumnDescription("")]
    public string MeteKeyWords { get; set; }

    [ColumnDescription("")]
    public string Category { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int BuyCount { get; set; }

    [ColumnDescription("")]
    public string BuyCountDesc { get; set; }

    [ColumnDescription("")]
    public string PageDesc { get; set; }
  }
}
