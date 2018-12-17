using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class tb_SEOControl
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string SiteType { get; set; }

    [ColumnDescription("")]
    public string SeoType { get; set; }

    [ColumnDescription("")]
    public string Data { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }
  }
}
