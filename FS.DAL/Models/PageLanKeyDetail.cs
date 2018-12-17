using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PageLanKeyDetail
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int KeyID { get; set; }

    [ColumnDescription("")]
    public string Value { get; set; }

    [ColumnDescription("")]
    public int LanID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
