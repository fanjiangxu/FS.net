using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SeoCreateLog
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public int TypeID { get; set; }

    [ColumnDescription("")]
    public string OtherID { get; set; }

    [ColumnDescription("")]
    public int CreateType { get; set; }

    [ColumnDescription("")]
    public string SumRow { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }
  }
}
