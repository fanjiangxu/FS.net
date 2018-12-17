using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MemberCouponAndVipDiscount
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public string CouponCode { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public decimal CouponMoney { get; set; }

    [ColumnDescription("")]
    public decimal VipDiscount { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
