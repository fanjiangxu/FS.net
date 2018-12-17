using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderPaymentMoneyForSales
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public int OrderId { get; set; }

    [ColumnDescription("")]
    public string Tx { get; set; }

    [ColumnDescription("")]
    public decimal PaymentMoney { get; set; }

    [ColumnDescription("")]
    public string PaymentStatus { get; set; }

    [ColumnDescription("")]
    public DateTime PaymentTime { get; set; }

    [ColumnDescription("")]
    public string Currency { get; set; }

    [ColumnDescription("")]
    public int Language { get; set; }
  }
}
