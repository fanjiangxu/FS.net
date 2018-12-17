using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Rate
  {

    [ColumnDescription("")]
    public int Year { get; set; }

    [ColumnDescription("")]
    public int YearMonth { get; set; }

    [ColumnDescription("")]
    public decimal Rate1 { get; set; }
  }
}
