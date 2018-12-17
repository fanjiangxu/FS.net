using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MemberFitCutDetail
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public int MemberFitCutId { get; set; }

    [ColumnDescription("")]
    public decimal PriceStart { get; set; }

    [ColumnDescription("")]
    public decimal PriceEnd { get; set; }

    [ColumnDescription("")]
    public decimal CutValue { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }
  }
}
