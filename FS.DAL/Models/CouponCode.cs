using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class CouponCode
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public int CouponRuleId { get; set; }

    [ColumnDescription("")]
    public int UserId { get; set; }

    [ColumnDescription("")]
    public string Code { get; set; }

    [ColumnDescription("")]
    public DateTime GetTime { get; set; }

    [ColumnDescription("")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int OrderId { get; set; }

    [ColumnDescription("")]
    public int siteid { get; set; }

    [ColumnDescription("")]
    public int SendId { get; set; }
  }
}
