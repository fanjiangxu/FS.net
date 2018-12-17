using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductCopyNew
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SourceProductID { get; set; }

    [ColumnDescription("")]
    public int SourceSiteID { get; set; }

    [ColumnDescription("")]
    public int TargetProductID { get; set; }

    [ColumnDescription("")]
    public int TargetSiteID { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }
  }
}
