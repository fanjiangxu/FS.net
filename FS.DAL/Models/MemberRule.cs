using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MemberRule
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public int Level { get; set; }

    [ColumnDescription("")]
    public decimal RuleStart { get; set; }

    [ColumnDescription("")]
    public decimal RuleEnd { get; set; }

    [ColumnDescription("")]
    public int IsCanDownGrade { get; set; }

    [ColumnDescription("")]
    public int PriorityShopping { get; set; }

    [ColumnDescription("")]
    public int SpecializedService { get; set; }

    [ColumnDescription("")]
    public int PriorityIssues { get; set; }

    [ColumnDescription("")]
    public decimal DownGreadValue { get; set; }

    [ColumnDescription("")]
    public int DownGreadValid { get; set; }
  }
}
