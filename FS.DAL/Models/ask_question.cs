using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ask_question
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string question_name { get; set; }

    [ColumnDescription("")]
    public string question_details { get; set; }

    [ColumnDescription("")]
    public string tag_id { get; set; }

    [ColumnDescription("")]
    public DateTime question_time { get; set; }

    [ColumnDescription("")]
    public int question_good { get; set; }

    [ColumnDescription("")]
    public int question_shenhe { get; set; }

    [ColumnDescription("")]
    public int category_id { get; set; }

    [ColumnDescription("")]
    public int category_bs { get; set; }

    [ColumnDescription("")]
    public int reply_numb { get; set; }

    [ColumnDescription("")]
    public int userid { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
