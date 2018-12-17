using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Order_Difference_Record
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int PaymentCompany { get; set; }

    [ColumnDescription("")]
    public int PaymentStatus { get; set; }

    [ColumnDescription("")]
    public string PlaformStatus { get; set; }

    [ColumnDescription("")]
    public decimal PaymentPrice { get; set; }

    [ColumnDescription("流水号")]
    public string PaymentTx { get; set; }

    [ColumnDescription("平台支付时间")]
    public DateTime PaymentTime { get; set; }

    [ColumnDescription("平台支付名称")]
    public string PlaformPayType { get; set; }

    [ColumnDescription("平台支付ID")]
    public int PayType { get; set; }

    [ColumnDescription("币种")]
    public string CurrencyName { get; set; }

    [ColumnDescription("退款数据")]
    public decimal RefundMoney { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("OrderDifference 外键")]
    public int DifferenceID { get; set; }
  }
}
