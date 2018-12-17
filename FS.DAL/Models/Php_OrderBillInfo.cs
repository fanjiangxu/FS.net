using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Php_OrderBillInfo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OldId { get; set; }

    [ColumnDescription("")]
    public int NewId { get; set; }

    [ColumnDescription("")]
    public string IncrementId { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public string Message { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }
  }
}
