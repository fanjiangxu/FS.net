using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MemberSendCouponByUser
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int Coupon { get; set; }

    [ColumnDescription("")]
    public int MemberRuleId { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }
  }
}
