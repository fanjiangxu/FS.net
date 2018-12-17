using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class YearMonth
  {

    [ColumnDescription("")]
    public int year { get; set; }

    [ColumnDescription("")]
    public int month { get; set; }

    [ColumnDescription("")]
    public int day { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }
  }
}
