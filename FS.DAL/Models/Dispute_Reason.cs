using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Dispute_Reason
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ParentID { get; set; }

    [ColumnDescription("1.paypal争议   2.GC争议 3.网站争议")]
    public int DisputeType { get; set; }

    [ColumnDescription("1.争议   0.非争议")]
    public bool DisputeState { get; set; }

    [ColumnDescription("")]
    public string DisputeReason { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int CreateUserID { get; set; }

    [ColumnDescription("")]
    public string CreateUserName { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }
  }
}
