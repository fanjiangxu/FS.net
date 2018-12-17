using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Shipping_City
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public string NationalName { get; set; }

    [ColumnDescription("")]
    public string CityNameA { get; set; }

    [ColumnDescription("")]
    public string CityNameB { get; set; }

    [ColumnDescription("")]
    public string CityNameC { get; set; }

    [ColumnDescription("")]
    public string CityNameD { get; set; }

    [ColumnDescription("")]
    public string CityNameE { get; set; }

    [ColumnDescription("")]
    public string ZIPA { get; set; }

    [ColumnDescription("")]
    public string ZIPB { get; set; }
  }
}
