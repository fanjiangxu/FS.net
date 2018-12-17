using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MemberRuleIndex
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public int MemberRuleId { get; set; }

    [ColumnDescription("")]
    public int RuleType { get; set; }

    [ColumnDescription("")]
    public int RuleStyle { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int Level { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }
  }
}
