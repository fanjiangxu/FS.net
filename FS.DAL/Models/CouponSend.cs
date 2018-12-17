using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class CouponSend
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public string Guid { get; set; }

    [ColumnDescription("")]
    public int UserId { get; set; }

    [ColumnDescription("")]
    public string GiveEmail { get; set; }

    [ColumnDescription("")]
    public DateTime TimeDeparture { get; set; }

    [ColumnDescription("")]
    public string CouponName { get; set; }

    [ColumnDescription("")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int CouponRulerId { get; set; }

    [ColumnDescription("")]
    public DateTime GetTimeF { get; set; }

    [ColumnDescription("")]
    public DateTime GetTimeS { get; set; }

    [ColumnDescription("")]
    public int CouponId { get; set; }

    [ColumnDescription("")]
    public string Value { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public string Explain { get; set; }

    [ColumnDescription("")]
    public int DrawState { get; set; }

    [ColumnDescription("")]
    public int Valid { get; set; }
  }
}
