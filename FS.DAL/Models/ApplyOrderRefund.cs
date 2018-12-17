using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ApplyOrderRefund
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int OrderBillID { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public DateTime ApplyTime { get; set; }

    [ColumnDescription("")]
    public int ApplyState { get; set; }

    [ColumnDescription("")]
    public int IsRefund { get; set; }

    [ColumnDescription("")]
    public int RefundReasonID { get; set; }

    [ColumnDescription("")]
    public string DetailContent { get; set; }

    [ColumnDescription("")]
    public string Images { get; set; }

    [ColumnDescription("")]
    public string Mobile { get; set; }

    [ColumnDescription("")]
    public decimal RefundMoney { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public decimal ShippingPrice { get; set; }

    [ColumnDescription("")]
    public decimal DiscountPrice { get; set; }

    [ColumnDescription("")]
    public string CurrencyName { get; set; }

    [ColumnDescription("")]
    public int RefundProductCount { get; set; }

    [ColumnDescription("")]
    public int NewInfoID { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int ChangeProductID { get; set; }

    [ColumnDescription("")]
    public int ChangeProductSKUID { get; set; }

    [ColumnDescription("")]
    public int SubmitStaffID { get; set; }

    [ColumnDescription("")]
    public DateTime SubmitTime { get; set; }

    [ColumnDescription("")]
    public string SubmitStaffName { get; set; }

    [ColumnDescription("")]
    public int SubmitApplyTimes { get; set; }

    [ColumnDescription("")]
    public int DelayDays { get; set; }

    [ColumnDescription("")]
    public decimal UserApplyRefundMoney { get; set; }

    [ColumnDescription("")]
    public string ReturnExpressNo { get; set; }

    [ColumnDescription("")]
    public string ReturnExpressType { get; set; }

    [ColumnDescription("")]
    public string Country { get; set; }

    [ColumnDescription("")]
    public string SendAddress { get; set; }

    [ColumnDescription("")]
    public int LangID { get; set; }
  }
}
