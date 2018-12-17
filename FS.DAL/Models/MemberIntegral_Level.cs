using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MemberIntegral_Level
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string MemberLevelName { get; set; }

    [ColumnDescription("")]
    public string MemberLevelCNName { get; set; }

    [ColumnDescription("")]
    public string MemberLevelDesc { get; set; }

    [ColumnDescription("")]
    public int MemberLevelType { get; set; }

    [ColumnDescription("")]
    public decimal ScopeStart { get; set; }

    [ColumnDescription("")]
    public decimal ScopeEnd { get; set; }

    [ColumnDescription("")]
    public decimal DownLevelMoney { get; set; }

    [ColumnDescription("")]
    public int ValidDay { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int Operator { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public DateTime OperatorTime { get; set; }
  }
}
