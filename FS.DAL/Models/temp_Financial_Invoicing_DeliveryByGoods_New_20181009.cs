using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class temp_Financial_Invoicing_DeliveryByGoods_New_20181009
  {

    [ColumnDescription("")]
    public DateTime DeliveryTime { get; set; }

    [ColumnDescription("")]
    public DateTime SettlementTime { get; set; }

    [ColumnDescription("")]
    public int GoodsID { get; set; }

    [ColumnDescription("")]
    public int OrganizationID { get; set; }

    [ColumnDescription("")]
    public int CompanyID { get; set; }

    [ColumnDescription("")]
    public string BillID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int SKUID { get; set; }

    [ColumnDescription("")]
    public int SaleGroup { get; set; }

    [ColumnDescription("")]
    public int DeliveryGoodsCount { get; set; }

    [ColumnDescription("")]
    public string DeliveryGoodsSumCost { get; set; }

    [ColumnDescription("")]
    public string SaleDeliveryLeftFreight { get; set; }

    [ColumnDescription("")]
    public string DeliveryGoodsSumCostEnd { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string Rmark { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public bool IsDelete { get; set; }

    [ColumnDescription("")]
    public int PackageID { get; set; }

    [ColumnDescription("")]
    public string ExpressNo { get; set; }

    [ColumnDescription("")]
    public string OrderID { get; set; }

    [ColumnDescription("")]
    public int InStockDay { get; set; }

    [ColumnDescription("")]
    public int ProductCategoryID { get; set; }

    [ColumnDescription("")]
    public int BrandID { get; set; }

    [ColumnDescription("")]
    public string CostDiscountProportion { get; set; }

    [ColumnDescription("")]
    public string DiscountDeliveryGoodsSumCost { get; set; }

    [ColumnDescription("")]
    public string DiscountCostCha { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }
  }
}
