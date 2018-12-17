using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class AdverFocus
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int AdvertisingID { get; set; }

    [ColumnDescription("")]
    public string FocusAltLable { get; set; }

    [ColumnDescription("")]
    public string FocusUrl { get; set; }

    [ColumnDescription("")]
    public string FocusTitle { get; set; }

    [ColumnDescription("")]
    public string FocusRegion { get; set; }

    [ColumnDescription("")]
    public bool IfDel { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
