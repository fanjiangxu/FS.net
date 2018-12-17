using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SkuChangeMessage
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string SKUID { get; set; }

    [ColumnDescription("")]
    public string SPUID { get; set; }

    [ColumnDescription("")]
    public string Value { get; set; }

    [ColumnDescription("")]
    public int ChangeType { get; set; }

    [ColumnDescription("")]
    public DateTime ChangeTime { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
