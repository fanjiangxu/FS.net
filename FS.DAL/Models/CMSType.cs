using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class CMSType
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public int ParentID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int ManageID { get; set; }

    [ColumnDescription("")]
    public string DailyDealsImage { get; set; }

    [ColumnDescription("")]
    public string RemarkIDs { get; set; }

    [ColumnDescription("")]
    public string BrandStoryUrl { get; set; }

    [ColumnDescription("平台:1代表App")]
    public int Platform { get; set; }

    [ColumnDescription("")]
    public DateTime StartTime { get; set; }

    [ColumnDescription("")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("app类目菜单是否显示此专题入口")]
    public int ShowCategory { get; set; }
  }
}
