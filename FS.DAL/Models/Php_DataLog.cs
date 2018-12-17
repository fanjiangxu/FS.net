using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Php_DataLog
  {

    [ColumnDescription("")]
    public string ID { get; set; }

    [ColumnDescription("")]
    public int OldId { get; set; }

    [ColumnDescription("")]
    public int NewId { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public string LogData { get; set; }
  }
}
