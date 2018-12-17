using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductUrl
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int PID { get; set; }

    [ColumnDescription("")]
    public int CategoryID { get; set; }

    [ColumnDescription("")]
    public string ProductUrl1 { get; set; }

    [ColumnDescription("")]
    public int state { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string ProductNo { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }
  }
}
