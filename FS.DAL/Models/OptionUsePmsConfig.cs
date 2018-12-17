using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OptionUsePmsConfig
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int PmsCategeoryID { get; set; }

    [ColumnDescription("状态：1=启用；-1=禁用")]
    public int State { get; set; }
  }
}
