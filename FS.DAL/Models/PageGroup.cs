using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PageGroup
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string CNName { get; set; }

    [ColumnDescription("")]
    public string PagePath { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
