using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ADS2
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public string Url { get; set; }

    [ColumnDescription("")]
    public string Img { get; set; }

    [ColumnDescription("")]
    public string Size { get; set; }

    [ColumnDescription("")]
    public int PID { get; set; }

    [ColumnDescription("")]
    public string Keys { get; set; }

    [ColumnDescription("")]
    public int ShowType { get; set; }

    [ColumnDescription("")]
    public DateTime StartDate { get; set; }

    [ColumnDescription("")]
    public DateTime EndDate { get; set; }

    [ColumnDescription("")]
    public int WeekDay { get; set; }

    [ColumnDescription("")]
    public DateTime StartTime { get; set; }

    [ColumnDescription("")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public int CategoryID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string HtmlContent { get; set; }

    [ColumnDescription("")]
    public int hasTimeGo { get; set; }

    [ColumnDescription("")]
    public string OrderBy { get; set; }

    [ColumnDescription("")]
    public string FilterBy { get; set; }

    [ColumnDescription("")]
    public int BusinessID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int BusinessType { get; set; }
  }
}
