using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductPrepareLog
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int PrepareRuleID { get; set; }

    [ColumnDescription("")]
    public string PrepareDateOld { get; set; }

    [ColumnDescription("")]
    public string PrepareDateNew { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }
  }
}
