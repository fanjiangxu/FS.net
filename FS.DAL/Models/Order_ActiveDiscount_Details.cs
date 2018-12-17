using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Order_ActiveDiscount_Details
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public string ActiveName { get; set; }

    [ColumnDescription("")]
    public int DiscountType { get; set; }

    [ColumnDescription("")]
    public decimal DiscountUSDMoney { get; set; }

    [ColumnDescription("")]
    public decimal DiscountCurrenyMoney { get; set; }
  }
}
