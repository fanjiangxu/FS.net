using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MemberIntegral_ValidDay
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UseScene { get; set; }

    [ColumnDescription("")]
    public int ValidDay { get; set; }

    [ColumnDescription("")]
    public int Operator { get; set; }

    [ColumnDescription("")]
    public DateTime OperatorTime { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
