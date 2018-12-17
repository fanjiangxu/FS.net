using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class CountryCode
  {

    [ColumnDescription("")]
    public string id { get; set; }

    [ColumnDescription("")]
    public string Country { get; set; }

    [ColumnDescription("")]
    public string Two { get; set; }

    [ColumnDescription("")]
    public string Three { get; set; }

    [ColumnDescription("")]
    public int KID { get; set; }
  }
}
