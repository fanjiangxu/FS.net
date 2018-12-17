using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MemberUser
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public int UsersId { get; set; }

    [ColumnDescription("")]
    public int mlevel { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime UpgradeTime { get; set; }

    [ColumnDescription("")]
    public DateTime LastSystemSendCouponTime { get; set; }

    [ColumnDescription("")]
    public decimal SumCOUNT { get; set; }

    [ColumnDescription("")]
    public int isDegrade { get; set; }
  }
}
