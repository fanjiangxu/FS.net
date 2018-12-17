using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ShopCartMix
  {

    [ColumnDescription("")]
    public int ShopCartID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int BuyCount { get; set; }

    [ColumnDescription("")]
    public string Remark2 { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public decimal Discount { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }
  }
}
