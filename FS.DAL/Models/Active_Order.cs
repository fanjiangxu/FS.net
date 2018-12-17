using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Active_Order
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("产品减现的多币种钱")]
    public decimal PorductDiscountCurrencyPrice { get; set; }

    [ColumnDescription("coupon减现的多币种钱")]
    public decimal CouponCurrencyPrice { get; set; }

    [ColumnDescription("会员减现的多币种钱")]
    public decimal VipCurrencyPrice { get; set; }

    [ColumnDescription("运费减现的钱")]
    public decimal ShippingCurrencyPrice { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
