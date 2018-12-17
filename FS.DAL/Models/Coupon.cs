using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Coupon
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public decimal Value { get; set; }

    [ColumnDescription("")]
    public decimal LimitS { get; set; }

    [ColumnDescription("")]
    public decimal LimitF { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }
  }
}
