using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Feedback
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string Content { get; set; }

    [ColumnDescription("")]
    public string URL { get; set; }

    [ColumnDescription("")]
    public int AuditStatus { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int FeedbackGUID { get; set; }

    [ColumnDescription("")]
    public string PromoCode { get; set; }
  }
}
