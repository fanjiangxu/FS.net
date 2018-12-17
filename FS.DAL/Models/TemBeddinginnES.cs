using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class TemBeddinginnES
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public string tx { get; set; }

    [ColumnDescription("")]
    public int state { get; set; }

    [ColumnDescription("")]
    public DateTime paytime { get; set; }

    [ColumnDescription("")]
    public string price_precount { get; set; }

    [ColumnDescription("")]
    public int siteID { get; set; }
  }
}
