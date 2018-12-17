using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MemberIntegral_Active
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string ActiveName { get; set; }

    [ColumnDescription("")]
    public DateTime StartTime { get; set; }

    [ColumnDescription("")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("")]
    public string MemberLevelScopeJSON { get; set; }

    [ColumnDescription("")]
    public string PlatformJSON { get; set; }

    [ColumnDescription("")]
    public int Status { get; set; }

    [ColumnDescription("")]
    public decimal IntegralMultiple { get; set; }

    [ColumnDescription("")]
    public int RestrictClass { get; set; }

    [ColumnDescription("")]
    public string ScopeIDScopeJSON { get; set; }

    [ColumnDescription("")]
    public string ExcludeJSONSPUIDJSON { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int Operator { get; set; }

    [ColumnDescription("")]
    public DateTime OperatorTime { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }
  }
}
