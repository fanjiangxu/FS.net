using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Product_Sku
  {

    [ColumnDescription("")]
    public int SkuID { get; set; }

    [ColumnDescription("")]
    public int SpuID { get; set; }

    [ColumnDescription("")]
    public int IsValid { get; set; }

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
    public int Weight { get; set; }

    [ColumnDescription("")]
    public string ValuesJson { get; set; }

    [ColumnDescription("")]
    public string SpecificationCode { get; set; }
  }
}
