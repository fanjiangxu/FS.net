using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Fact_Cate
  {

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string Date { get; set; }

    [ColumnDescription("")]
    public int CountryID { get; set; }

    [ColumnDescription("")]
    public int LanguageID { get; set; }

    [ColumnDescription("")]
    public string Amount { get; set; }

    [ColumnDescription("")]
    public int BillCouont { get; set; }

    [ColumnDescription("")]
    public int OrderCount { get; set; }

    [ColumnDescription("")]
    public string CateID { get; set; }

    [ColumnDescription("")]
    public int OrderSource { get; set; }

    [ColumnDescription("")]
    public string Parentids { get; set; }
  }
}
