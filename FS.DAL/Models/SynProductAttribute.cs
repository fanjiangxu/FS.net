using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SynProductAttribute
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string ProductIDs { get; set; }

    [ColumnDescription("")]
    public string Attributes { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int state { get; set; }

    [ColumnDescription("")]
    public int SourceSiteID { get; set; }

    [ColumnDescription("")]
    public string CategoryIDs { get; set; }

    [ColumnDescription("")]
    public string TargetSiteIDs { get; set; }

    [ColumnDescription("")]
    public string synBeginDate { get; set; }

    [ColumnDescription("")]
    public string synEndDate { get; set; }

    [ColumnDescription("")]
    public int IsCover { get; set; }
  }
}
