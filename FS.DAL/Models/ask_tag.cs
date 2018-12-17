using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ask_tag
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string tag_name { get; set; }

    [ColumnDescription("")]
    public DateTime tag_time { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
