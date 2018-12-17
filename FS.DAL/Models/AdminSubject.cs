using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class AdminSubject
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SubID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string ToDept { get; set; }

    [ColumnDescription("")]
    public int ToUserID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public string Content { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public DateTime DoDate { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public int IsRead { get; set; }

    [ColumnDescription("")]
    public int IsToRead { get; set; }

    [ColumnDescription("")]
    public string Images { get; set; }

    [ColumnDescription("")]
    public int DoUserID { get; set; }

    [ColumnDescription("")]
    public int IsNi { get; set; }

    [ColumnDescription("")]
    public int SubType { get; set; }

    [ColumnDescription("")]
    public int siteID { get; set; }

    [ColumnDescription("")]
    public DateTime RemindDate { get; set; }

    [ColumnDescription("")]
    public int RemindState { get; set; }

    [ColumnDescription("")]
    public int IsRemand { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int CauseType { get; set; }
  }
}
