using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Evaluate
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public int ServiceID { get; set; }

    [ColumnDescription("")]
    public int SourceID { get; set; }

    [ColumnDescription("")]
    public int Service { get; set; }

    [ColumnDescription("")]
    public int Response { get; set; }

    [ColumnDescription("")]
    public int Reply { get; set; }

    [ColumnDescription("")]
    public string Suggestion { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int AdminID { get; set; }
  }
}
