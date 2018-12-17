using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PayTypeRecord
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public string Tx { get; set; }

    [ColumnDescription("")]
    public decimal Amount { get; set; }

    [ColumnDescription("")]
    public int PayType { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string CurrencyName { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public string TypeID { get; set; }

    [ColumnDescription("")]
    public string PaymentName { get; set; }

    [ColumnDescription("")]
    public int PaymentStatus { get; set; }

    [ColumnDescription("")]
    public int SubmitCount { get; set; }
  }
}
