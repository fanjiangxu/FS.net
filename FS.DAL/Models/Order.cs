using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Order
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public string Tx { get; set; }

    [ColumnDescription("")]
    public decimal Price_Product { get; set; }

    [ColumnDescription("")]
    public decimal Price_Count { get; set; }

    [ColumnDescription("")]
    public decimal Price_PreCount { get; set; }

    [ColumnDescription("")]
    public decimal Price_PreCount1 { get; set; }

    [ColumnDescription("")]
    public string PreBack { get; set; }

    [ColumnDescription("")]
    public decimal Shipping { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public int Address1 { get; set; }

    [ColumnDescription("")]
    public int Address2 { get; set; }

    [ColumnDescription("")]
    public DateTime PayTime { get; set; }

    [ColumnDescription("")]
    public int PayType { get; set; }

    [ColumnDescription("")]
    public DateTime SendTime { get; set; }

    [ColumnDescription("")]
    public DateTime ConfirmSendTime { get; set; }

    [ColumnDescription("")]
    public DateTime CompletedTime { get; set; }

    [ColumnDescription("")]
    public DateTime CancelTime { get; set; }

    [ColumnDescription("")]
    public string ShipType { get; set; }

    [ColumnDescription("")]
    public string ShipNo { get; set; }

    [ColumnDescription("")]
    public string PromoCode { get; set; }

    [ColumnDescription("")]
    public string CancelRemark { get; set; }

    [ColumnDescription("")]
    public int CancelUserID { get; set; }

    [ColumnDescription("")]
    public string ShippingType { get; set; }

    [ColumnDescription("")]
    public string Gift { get; set; }

    [ColumnDescription("")]
    public int DisputedType { get; set; }

    [ColumnDescription("")]
    public int IsFastOrder { get; set; }

    [ColumnDescription("")]
    public int FastID { get; set; }

    [ColumnDescription("")]
    public int IsComment { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int RemarkState { get; set; }

    [ColumnDescription("")]
    public int PaymentStatus { get; set; }

    [ColumnDescription("")]
    public int RefundType { get; set; }

    [ColumnDescription("")]
    public int IsDisputed { get; set; }

    [ColumnDescription("")]
    public decimal Prepay { get; set; }

    [ColumnDescription("")]
    public DateTime NewStockDate { get; set; }

    [ColumnDescription("")]
    public int IsDanger { get; set; }

    [ColumnDescription("")]
    public int IsContact { get; set; }

    [ColumnDescription("")]
    public int UsedIntegral { get; set; }

    [ColumnDescription("")]
    public int Currency { get; set; }

    [ColumnDescription("")]
    public int OrderSource { get; set; }

    [ColumnDescription("")]
    public string UserAgent { get; set; }

    [ColumnDescription("")]
    public string CurrencyName { get; set; }

    [ColumnDescription("")]
    public decimal CurrencyRate { get; set; }

    [ColumnDescription("")]
    public decimal CurrencyPrice { get; set; }

    [ColumnDescription("")]
    public string PayCurrencyName { get; set; }

    [ColumnDescription("")]
    public decimal PayCurrencyPrice { get; set; }

    [ColumnDescription("1为paypal 快捷支付 2pyapal 信用卡,3为gc 信用卡，4为Braintree 信用卡，5为WorldPay信用卡")]
    public int IsFastPaypal { get; set; }

    [ColumnDescription("")]
    public int IsGuest { get; set; }

    [ColumnDescription("")]
    public decimal OriginalPrice { get; set; }

    [ColumnDescription("是否可拆包：1:可拆包（默认）,0：不可拆包（整单发货）")]
    public int IsUnpack { get; set; }

    [ColumnDescription("")]
    public int UpdateCount { get; set; }

    [ColumnDescription("")]
    public int IsPreSale { get; set; }

    [ColumnDescription("")]
    public int IsHalf { get; set; }

    [ColumnDescription("")]
    public DateTime SyncTime { get; set; }

    [ColumnDescription("")]
    public decimal CurrencyShipping { get; set; }

    [ColumnDescription("")]
    public int creditcardtype { get; set; }

    [ColumnDescription("")]
    public decimal CurrencyShippingMonery { get; set; }
  }
}
