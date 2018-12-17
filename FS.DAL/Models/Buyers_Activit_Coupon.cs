using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Buyers_Activit_Coupon
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public int ActivitID { get; set; }

    [ColumnDescription("")]
    public int CouponRuleID { get; set; }
  }
}
