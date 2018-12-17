using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ReportAccount
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime PayTime { get; set; }

    [ColumnDescription("")]
    public decimal TotalIncome { get; set; }

    [ColumnDescription("")]
    public decimal Purchase_Cost { get; set; }

    [ColumnDescription("")]
    public decimal Delivery_Cost { get; set; }

    [ColumnDescription("")]
    public decimal Refund { get; set; }

    [ColumnDescription("")]
    public decimal UrgentFreight { get; set; }

    [ColumnDescription("")]
    public decimal Premium { get; set; }

    [ColumnDescription("")]
    public int PayType { get; set; }

    [ColumnDescription("")]
    public int Currency { get; set; }

    [ColumnDescription("")]
    public decimal Scale { get; set; }

    [ColumnDescription("")]
    public decimal Price_Product { get; set; }

    [ColumnDescription("")]
    public decimal Price_Count { get; set; }

    [ColumnDescription("")]
    public decimal Price_PreCount1 { get; set; }

    [ColumnDescription("")]
    public decimal Shipping { get; set; }

    [ColumnDescription("")]
    public int SOURCE { get; set; }

    [ColumnDescription("")]
    public decimal PriceWithOutShipping { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public int DeliveryID { get; set; }

    [ColumnDescription("")]
    public int UrgentFreight_PayType { get; set; }

    [ColumnDescription("")]
    public int UrgentFreight_LanguageID { get; set; }

    [ColumnDescription("")]
    public string UrgentFreight_TX { get; set; }

    [ColumnDescription("")]
    public string TX { get; set; }

    [ColumnDescription("")]
    public string shippingType { get; set; }

    [ColumnDescription("")]
    public int buycount { get; set; }

    [ColumnDescription("")]
    public string ParentIDs { get; set; }

    [ColumnDescription("")]
    public decimal ProductWeight { get; set; }

    [ColumnDescription("")]
    public int BillState { get; set; }
  }
}
