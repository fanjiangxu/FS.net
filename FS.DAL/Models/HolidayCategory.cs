using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class HolidayCategory
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int HolidayID { get; set; }

    [ColumnDescription("")]
    public int CatetoryID { get; set; }

    [ColumnDescription("")]
    public string MetaTitle { get; set; }

    [ColumnDescription("")]
    public string MetaDesc { get; set; }

    [ColumnDescription("")]
    public string MetaKeyword { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int AdminID { get; set; }

    [ColumnDescription("调取规则，手动或者自动")]
    public int Rules { get; set; }

    [ColumnDescription("推荐产品的排序规则")]
    public int OrderBy { get; set; }

    [ColumnDescription("列表页排序")]
    public string SortBy { get; set; }

    [ColumnDescription("")]
    public string ProductRange { get; set; }
  }
}
