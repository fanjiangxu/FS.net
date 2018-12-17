using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PermissionPage
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Url { get; set; }

    [ColumnDescription("")]
    public string PageName { get; set; }

    [ColumnDescription("")]
    public int GroupID { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public int state { get; set; }
  }
}
