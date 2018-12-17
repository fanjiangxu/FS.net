using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class KeyWordLog
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public DateTime OperateDate { get; set; }

    [ColumnDescription("")]
    public int OperateType { get; set; }

    [ColumnDescription("")]
    public int Source { get; set; }

    [ColumnDescription("")]
    public int Counts { get; set; }

    [ColumnDescription("")]
    public int AllCounts { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
