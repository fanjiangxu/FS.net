using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Product_PurchasePrice
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public decimal PurchasePrice { get; set; }

    [ColumnDescription("")]
    public int skuID { get; set; }

    [ColumnDescription("")]
    public string Specification { get; set; }

    [ColumnDescription("")]
    public int ErpID { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }
  }
}
