using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class InfoUser
  {

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string UserName { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int ICount { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }
  }
}
