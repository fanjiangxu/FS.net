using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class AdaptiveProduct
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OriginalPID { get; set; }

    [ColumnDescription("")]
    public string NowPID { get; set; }

    [ColumnDescription("")]
    public string Percents { get; set; }

    [ColumnDescription("")]
    public int GroupID { get; set; }
  }
}
