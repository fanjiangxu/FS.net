using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ask_categoryb
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string categoryb_name { get; set; }

    [ColumnDescription("")]
    public int category_bs { get; set; }

    [ColumnDescription("")]
    public int categorya_id { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
