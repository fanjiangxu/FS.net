using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Dispute_Remark
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public bool IsHistoryDispute { get; set; }

    [ColumnDescription("")]
    public int DisputeType { get; set; }

    [ColumnDescription("")]
    public bool IsDispute { get; set; }

    [ColumnDescription("")]
    public int ParentReasonID { get; set; }

    [ColumnDescription("")]
    public string ParentReason { get; set; }

    [ColumnDescription("")]
    public int DisputeReasonID { get; set; }

    [ColumnDescription("")]
    public string DisputeReason { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int DisputeUserID { get; set; }

    [ColumnDescription("")]
    public string DisputeUserName { get; set; }

    [ColumnDescription("")]
    public DateTime DisputeCreateTime { get; set; }

    [ColumnDescription("")]
    public int HandleUserID { get; set; }

    [ColumnDescription("")]
    public string HandleUserName { get; set; }

    [ColumnDescription("")]
    public DateTime HandleTime { get; set; }

    [ColumnDescription("")]
    public int HandleType { get; set; }

    [ColumnDescription("")]
    public int NotDisputeReasonID { get; set; }

    [ColumnDescription("")]
    public string NotDisputeReason { get; set; }

    [ColumnDescription("")]
    public int NotDisputeUserID { get; set; }

    [ColumnDescription("")]
    public string NotDisputeUserName { get; set; }

    [ColumnDescription("")]
    public DateTime NotDisputeCreateTime { get; set; }

    [ColumnDescription("")]
    public DateTime PlatformDisputeDate { get; set; }
  }
}
