using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class DisputeLog
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public string Type { get; set; }

    [ColumnDescription("")]
    public string ParentCode { get; set; }

    [ColumnDescription("")]
    public string Code { get; set; }

    [ColumnDescription("")]
    public int OperateID { get; set; }

    [ColumnDescription("")]
    public string operateDate { get; set; }

    [ColumnDescription("")]
    public bool IsDel { get; set; }
  }
}
