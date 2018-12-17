using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class HD_Video
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public string Content { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string CategoryIds { get; set; }

    [ColumnDescription("")]
    public string ParentIds { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int ReviewCount { get; set; }

    [ColumnDescription("")]
    public string images { get; set; }

    [ColumnDescription("")]
    public int ViewCount { get; set; }

    [ColumnDescription("")]
    public string VideoLink { get; set; }

    [ColumnDescription("")]
    public int LikeCount { get; set; }

    [ColumnDescription("")]
    public int IsRecommend { get; set; }
  }
}
