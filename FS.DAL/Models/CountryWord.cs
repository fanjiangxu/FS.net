using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class CountryWord
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int IsDefault { get; set; }

    [ColumnDescription("")]
    public string CNName { get; set; }

    [ColumnDescription("")]
    public string CountryName { get; set; }

    [ColumnDescription("")]
    public int CountryCode { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string CountryName_Jp { get; set; }

    [ColumnDescription("")]
    public string CountryName_Fr { get; set; }

    [ColumnDescription("")]
    public string CountryName_Es { get; set; }

    [ColumnDescription("")]
    public string Abbreviation { get; set; }

    [ColumnDescription("")]
    public string CurrencyCode { get; set; }
  }
}
