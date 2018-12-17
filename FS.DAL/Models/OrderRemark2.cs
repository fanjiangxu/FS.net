using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderRemark2
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string UserName { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public string State { get; set; }

    [ColumnDescription("")]
    public DateTime LastDate { get; set; }

    [ColumnDescription("")]
    public int DoUserID { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int RemarkLenght { get; set; }

    [ColumnDescription("")]
    public decimal RefundMoney { get; set; }

    [ColumnDescription("")]
    public int IsAud { get; set; }

    [ColumnDescription("")]
    public int IsRefund { get; set; }

    [ColumnDescription("")]
    public string RefundTX { get; set; }

    [ColumnDescription("")]
    public int AudUserID { get; set; }

    [ColumnDescription("")]
    public DateTime AudDate { get; set; }

    [ColumnDescription("")]
    public string DisputedReason { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int RefundType { get; set; }

    [ColumnDescription("")]
    public string AllowAdminID { get; set; }
  }
}
