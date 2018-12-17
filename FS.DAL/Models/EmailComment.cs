using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class EmailComment
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int CommentType { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int CommentLevel { get; set; }

    [ColumnDescription("")]
    public string CommentContent { get; set; }

    [ColumnDescription("")]
    public int ServiceUserID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
