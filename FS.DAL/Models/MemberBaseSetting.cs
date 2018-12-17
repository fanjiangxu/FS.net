using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MemberBaseSetting
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public int GradeStandards { get; set; }

    [ColumnDescription("")]
    public int DelayState { get; set; }

    [ColumnDescription("")]
    public int RegisterPreState { get; set; }

    [ColumnDescription("")]
    public int RecomendPreState { get; set; }
  }
}
