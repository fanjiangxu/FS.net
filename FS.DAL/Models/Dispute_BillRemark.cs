using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Dispute_BillRemark
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
    public int DisputeType { get; set; }

    [ColumnDescription("")]
    public int DisputeReasonID { get; set; }

    [ColumnDescription("")]
    public int ParentReasonID { get; set; }

    [ColumnDescription("")]
    public int NotDisputeReasonID { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public DateTime NotDisputeCreateTime { get; set; }
  }
}
