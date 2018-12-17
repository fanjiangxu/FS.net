using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderBill_BAK27
  {

    [ColumnDescription("")]
    public int OrderSource { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int BuyCount { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public decimal PriceCount { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public string Remark2 { get; set; }

    [ColumnDescription("")]
    public int SupplierID { get; set; }

    [ColumnDescription("")]
    public int IsComment { get; set; }

    [ColumnDescription("")]
    public int IsInquiry { get; set; }

    [ColumnDescription("")]
    public string ShipType { get; set; }

    [ColumnDescription("")]
    public string ShipNo { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public DateTime SendTime { get; set; }

    [ColumnDescription("")]
    public int IsSend { get; set; }

    [ColumnDescription("")]
    public string Gift { get; set; }

    [ColumnDescription("")]
    public string ParentIDs { get; set; }

    [ColumnDescription("")]
    public int remarkState { get; set; }

    [ColumnDescription("")]
    public int OrderState { get; set; }

    [ColumnDescription("")]
    public int IsFastOrder { get; set; }

    [ColumnDescription("")]
    public int FastID { get; set; }

    [ColumnDescription("")]
    public int IsCreatePhoto { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int BillType { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public int IsDisputed { get; set; }

    [ColumnDescription("")]
    public int RefundType { get; set; }

    [ColumnDescription("")]
    public int DisputedType { get; set; }

    [ColumnDescription("")]
    public DateTime ConfirmSendTime { get; set; }

    [ColumnDescription("")]
    public DateTime CompletedTime { get; set; }

    [ColumnDescription("")]
    public int IsPackage { get; set; }

    [ColumnDescription("")]
    public int CustomID { get; set; }

    [ColumnDescription("")]
    public int LanguageID { get; set; }

    [ColumnDescription("")]
    public string Color { get; set; }

    [ColumnDescription("")]
    public string Size { get; set; }

    [ColumnDescription("")]
    public string PrepareDate { get; set; }

    [ColumnDescription("")]
    public int UnHold { get; set; }

    [ColumnDescription("")]
    public decimal CurrencyRate { get; set; }

    [ColumnDescription("")]
    public decimal BillCurrencyPrice { get; set; }

    [ColumnDescription("")]
    public int KID { get; set; }

    [ColumnDescription("")]
    public string ProcurementRemark { get; set; }

    [ColumnDescription("")]
    public string SameImageColor { get; set; }

    [ColumnDescription("")]
    public string SameImageUrl { get; set; }

    [ColumnDescription("")]
    public int IsPreSale { get; set; }

    [ColumnDescription("")]
    public int IsHalf { get; set; }

    [ColumnDescription("")]
    public int ItmeType { get; set; }

    [ColumnDescription("")]
    public int ItemTypeID { get; set; }

    [ColumnDescription("")]
    public int IsPackageBox { get; set; }

    [ColumnDescription("")]
    public DateTime SyncTime { get; set; }

    [ColumnDescription("")]
    public decimal AppDealsDisCount { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }
  }
}
