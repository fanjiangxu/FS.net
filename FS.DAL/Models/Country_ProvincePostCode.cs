using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Country_ProvincePostCode
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int CountryID { get; set; }

    [ColumnDescription("")]
    public int Code { get; set; }

    [ColumnDescription("")]
    public string JA_Prefecture { get; set; }

    [ColumnDescription("")]
    public string JA_City { get; set; }

    [ColumnDescription("")]
    public string JA_Street { get; set; }

    [ColumnDescription("")]
    public string Prefecture { get; set; }

    [ColumnDescription("")]
    public string City { get; set; }

    [ColumnDescription("")]
    public string Street { get; set; }
  }
}
