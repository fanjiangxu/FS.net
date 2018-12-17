using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ask_reply
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string reply_name { get; set; }

    [ColumnDescription("")]
    public DateTime reply_time { get; set; }

    [ColumnDescription("")]
    public int reply_shenhe { get; set; }

    [ColumnDescription("")]
    public int reply_good { get; set; }

    [ColumnDescription("")]
    public int question_id { get; set; }

    [ColumnDescription("")]
    public int userid { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
