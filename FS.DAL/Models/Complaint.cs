using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Complaint
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public string Content { get; set; }

    [ColumnDescription("")]
    public string Images { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int BeforeState { get; set; }

    [ColumnDescription("")]
    public int CreateUserID { get; set; }

    [ColumnDescription("")]
    public int ConfirmUserID { get; set; }

    [ColumnDescription("")]
    public DateTime ConfirmTime { get; set; }

    [ColumnDescription("")]
    public string ConfirmRemark { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int IsReplay { get; set; }

    [ColumnDescription("")]
    public int ReplayID { get; set; }

    [ColumnDescription("")]
    public DateTime ReplayTime { get; set; }

    [ColumnDescription("")]
    public int ReplayUserID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int IsInfo { get; set; }

    [ColumnDescription("")]
    public int LanguageID { get; set; }

    [ColumnDescription("")]
    public int KID { get; set; }

    [ColumnDescription("")]
    public DateTime SyncDate { get; set; }
  }
}
