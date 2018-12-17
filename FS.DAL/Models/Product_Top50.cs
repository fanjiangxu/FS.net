using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Product_Top50
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string SupplierNO { get; set; }

    [ColumnDescription("")]
    public int StockCount { get; set; }

    [ColumnDescription("")]
    public int QualityQualified { get; set; }

    [ColumnDescription("")]
    public string ProductSource { get; set; }

    [ColumnDescription("")]
    public string Quality { get; set; }

    [ColumnDescription("")]
    public bool State { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public string RemarkQuality { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public int BuyCount { get; set; }

    [ColumnDescription("")]
    public int PurchaseCount { get; set; }

    [ColumnDescription("")]
    public int CategoryID { get; set; }
  }
}
