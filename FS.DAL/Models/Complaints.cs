using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Complaints
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public int InboxUId { get; set; }

    [ColumnDescription("")]
    public int GroupPercentageID { get; set; }

    [ColumnDescription("")]
    public DateTime ReplyDate { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
