using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Country_Province_Mapping
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string CNName { get; set; }

    [ColumnDescription("")]
    public string ENName { get; set; }

    [ColumnDescription("")]
    public string ProvinceCNName { get; set; }

    [ColumnDescription("")]
    public string ProvinceENName { get; set; }

    [ColumnDescription("")]
    public string ProvinceCode { get; set; }

    [ColumnDescription("")]
    public int CountryID { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
