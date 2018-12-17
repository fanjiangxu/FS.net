using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PaypalEmail
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public string TX { get; set; }

    [ColumnDescription("")]
    public decimal Money { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public DateTime SendDate { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int Num { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public string Content { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int mailType { get; set; }

    [ColumnDescription("")]
    public int ExecUserID { get; set; }

    [ColumnDescription("")]
    public DateTime ExecDate { get; set; }

    [ColumnDescription("")]
    public int DoID { get; set; }

    [ColumnDescription("")]
    public int messageCount { get; set; }

    [ColumnDescription("")]
    public int EmailType { get; set; }

    [ColumnDescription("")]
    public string MailMark { get; set; }
  }
}
