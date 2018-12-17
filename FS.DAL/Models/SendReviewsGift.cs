using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SendReviewsGift
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string UserName { get; set; }

    [ColumnDescription("")]
    public DateTime Time { get; set; }

    [ColumnDescription("")]
    public string Type { get; set; }

    [ColumnDescription("")]
    public string Image { get; set; }

    [ColumnDescription("")]
    public string Description { get; set; }

    [ColumnDescription("")]
    public int CommentTimes { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string ProductUrl { get; set; }
  }
}
