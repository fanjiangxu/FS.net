using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class HolidayNew
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public string Images { get; set; }

    [ColumnDescription("")]
    public string BeginTime { get; set; }

    [ColumnDescription("")]
    public string EndTime { get; set; }

    [ColumnDescription("")]
    public string Information { get; set; }

    [ColumnDescription("")]
    public string MetaTitle { get; set; }

    [ColumnDescription("")]
    public string MetaDesc { get; set; }

    [ColumnDescription("")]
    public string MetaKeyword { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int adminid { get; set; }

    [ColumnDescription("")]
    public string ImagesCategory { get; set; }

    [ColumnDescription("")]
    public string CategoryIDs { get; set; }

    [ColumnDescription("")]
    public int CProductCount { get; set; }

    [ColumnDescription("")]
    public string Url { get; set; }
  }
}
