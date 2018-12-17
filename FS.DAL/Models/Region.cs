using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Region
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int CountryID { get; set; }

    [ColumnDescription("")]
    public string CountryCNName { get; set; }

    [ColumnDescription("")]
    public string CountryENName { get; set; }

    [ColumnDescription("")]
    public string ProvinceENName { get; set; }

    [ColumnDescription("")]
    public string ProvinceCode { get; set; }
  }
}
