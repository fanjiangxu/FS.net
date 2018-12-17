using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class AccountChecking
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int PaymentID { get; set; }

    [ColumnDescription("")]
    public string PaymentName { get; set; }

    [ColumnDescription("")]
    public string OrderID { get; set; }

    [ColumnDescription("")]
    public string Tx { get; set; }

    [ColumnDescription("")]
    public string PayType { get; set; }

    [ColumnDescription("")]
    public string CurrencyName { get; set; }

    [ColumnDescription("")]
    public decimal Amount { get; set; }

    [ColumnDescription("")]
    public DateTime StockDate { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }
  }
}
