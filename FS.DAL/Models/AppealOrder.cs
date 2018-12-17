using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class AppealOrder
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public DateTime CommunicationDate { get; set; }

    [ColumnDescription("")]
    public int CommunicationType { get; set; }

    [ColumnDescription("")]
    public string AppealReason { get; set; }

    [ColumnDescription("")]
    public int AppealUserID { get; set; }

    [ColumnDescription("")]
    public DateTime AppealDate { get; set; }

    [ColumnDescription("")]
    public DateTime CommitDate { get; set; }

    [ColumnDescription("")]
    public string PerformanceUserID { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public DateTime AuditDate { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int AuditUserID { get; set; }
  }
}
