using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class FengKongRule
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int RuleType { get; set; }

    [ColumnDescription("")]
    public string RuleValue { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int AddUserID { get; set; }

    [ColumnDescription("")]
    public int HandleUserID { get; set; }

    [ColumnDescription("")]
    public DateTime HandleDate { get; set; }

    [ColumnDescription("")]
    public string CountryID { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int IsStart { get; set; }
  }
}
