using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class temppriceee
  {

    [ColumnDescription("")]
    public int counts { get; set; }

    [ColumnDescription("")]
    public decimal sums { get; set; }

    [ColumnDescription("")]
    public int CountryID { get; set; }
  }
}
