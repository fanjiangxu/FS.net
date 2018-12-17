using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SKU
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SKUID { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public string ImageUrl { get; set; }

    [ColumnDescription("")]
    public int IsShow { get; set; }

    [ColumnDescription("")]
    public string SpecificationText { get; set; }

    [ColumnDescription("")]
    public string SpecificationCode { get; set; }

    [ColumnDescription("")]
    public int IsValid { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int LeadTimeMin { get; set; }

    [ColumnDescription("")]
    public int LeadTimeMax { get; set; }

    [ColumnDescription("")]
    public int StockCount { get; set; }

    [ColumnDescription("")]
    public int IsDefault { get; set; }

    [ColumnDescription("")]
    public int SkuType { get; set; }

    [ColumnDescription("")]
    public decimal Weight { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public decimal OriginalPC { get; set; }

    [ColumnDescription("")]
    public decimal OriginalM { get; set; }

    [ColumnDescription("")]
    public decimal OriginalAPP { get; set; }

    [ColumnDescription("")]
    public decimal PricePC { get; set; }

    [ColumnDescription("")]
    public decimal PriceM { get; set; }

    [ColumnDescription("")]
    public decimal PriceAPP { get; set; }

    [ColumnDescription("")]
    public decimal CostPrice { get; set; }

    [ColumnDescription("")]
    public decimal MarketPrice { get; set; }

    [ColumnDescription("")]
    public string PlatformJSON { get; set; }

    [ColumnDescription("")]
    public int MinBuyCount { get; set; }

    [ColumnDescription("")]
    public int MaxBuyCount { get; set; }
  }
}
