using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MemberIntegral_Level_Detail
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int MemberLevelID { get; set; }

    [ColumnDescription("")]
    public decimal IntegralMultiple { get; set; }

    [ColumnDescription("")]
    public string PlatformJSON { get; set; }

    [ColumnDescription("")]
    public int Status { get; set; }

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
