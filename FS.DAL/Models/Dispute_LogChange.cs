using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Dispute_LogChange
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Casetype { get; set; }

    [ColumnDescription("")]
    public string OriginaltransactionID { get; set; }

    [ColumnDescription("")]
    public string Transactiondate { get; set; }

    [ColumnDescription("")]
    public string Claimantemailaddress { get; set; }

    [ColumnDescription("")]
    public string Casefilingdate { get; set; }

    [ColumnDescription("")]
    public string Disputedamount { get; set; }

    [ColumnDescription("")]
    public string Disputedcurrency { get; set; }

    [ColumnDescription("")]
    public DateTime InsertDate { get; set; }

    [ColumnDescription("")]
    public string SiteName { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string EventReason { get; set; }

    [ColumnDescription("")]
    public int HandleUserID { get; set; }

    [ColumnDescription("")]
    public string HandleUserName { get; set; }

    [ColumnDescription("")]
    public DateTime HandleTime { get; set; }

    [ColumnDescription("")]
    public string CaseState { get; set; }

    [ColumnDescription("")]
    public string Flows { get; set; }

    [ColumnDescription("")]
    public string ClearType { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }
  }
}
