using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PreProduct
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string ProductID { get; set; }

    [ColumnDescription("")]
    public string AdminID { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("0:关闭；1:开启")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string SiteID { get; set; }

    [ColumnDescription("")]
    public string PlatformType { get; set; }
  }
}
