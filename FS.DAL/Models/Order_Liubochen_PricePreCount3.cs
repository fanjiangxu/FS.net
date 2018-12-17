using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Order_Liubochen_PricePreCount3
  {

    [ColumnDescription("")]
    public decimal Price_PreCount1 { get; set; }

    [ColumnDescription("")]
    public int PayType { get; set; }

    [ColumnDescription("")]
    public int Currency { get; set; }

    [ColumnDescription("")]
    public decimal Shipping { get; set; }

    [ColumnDescription("")]
    public decimal Price_Count { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string CurrencyName { get; set; }

    [ColumnDescription("")]
    public decimal CurrencyRate { get; set; }

    [ColumnDescription("")]
    public decimal CurrencyPrice { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
