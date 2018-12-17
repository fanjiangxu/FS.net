using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class CouponRuler
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public int CouponId { get; set; }

    [ColumnDescription("")]
    public DateTime GetTimeS { get; set; }

    [ColumnDescription("")]
    public DateTime GetTimeF { get; set; }

    [ColumnDescription("")]
    public int Valid { get; set; }

    [ColumnDescription("")]
    public int TotalCount { get; set; }

    [ColumnDescription("")]
    public int Disposable { get; set; }

    [ColumnDescription("")]
    public int Limitations { get; set; }

    [ColumnDescription("")]
    public string URL { get; set; }

    [ColumnDescription("")]
    public string Explain { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public string LimitValue { get; set; }

    [ColumnDescription("")]
    public int CouponSendId { get; set; }

    [ColumnDescription("")]
    public int restrictCount { get; set; }
  }
}
