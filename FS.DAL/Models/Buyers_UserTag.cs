using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Buyers_UserTag
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string Tag { get; set; }

    [ColumnDescription("")]
    public int ActivitID { get; set; }

    [ColumnDescription("")]
    public int SelectCount { get; set; }

    [ColumnDescription("")]
    public bool IsDelete { get; set; }
  }
}
