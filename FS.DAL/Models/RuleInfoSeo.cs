using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class RuleInfoSeo
  {

    [ColumnDescription("")]
    public int RuleID { get; set; }

    [ColumnDescription("")]
    public string RuleKey { get; set; }

    [ColumnDescription("")]
    public string RuleValue { get; set; }

    [ColumnDescription("")]
    public int RuleClass { get; set; }

    [ColumnDescription("")]
    public int RuleIsUse { get; set; }

    [ColumnDescription("")]
    public int RuleLevel { get; set; }

    [ColumnDescription("")]
    public int RuleSiteId { get; set; }

    [ColumnDescription("")]
    public string RuleUrl { get; set; }

    [ColumnDescription("")]
    public int RuleState { get; set; }

    [ColumnDescription("")]
    public DateTime RuleRangDate { get; set; }

    [ColumnDescription("")]
    public int RuleLanguage { get; set; }
  }
}
