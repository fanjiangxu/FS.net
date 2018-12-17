using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ask_supplement
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string supplement_content { get; set; }

    [ColumnDescription("")]
    public DateTime supplement_time { get; set; }

    [ColumnDescription("")]
    public int question_id { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
