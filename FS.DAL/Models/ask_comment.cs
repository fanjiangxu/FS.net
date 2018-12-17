using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ask_comment
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string comment_content { get; set; }

    [ColumnDescription("")]
    public DateTime comment_time { get; set; }

    [ColumnDescription("")]
    public int reply_id { get; set; }

    [ColumnDescription("")]
    public int userid { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
