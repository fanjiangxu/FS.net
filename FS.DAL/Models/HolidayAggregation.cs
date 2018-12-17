using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class HolidayAggregation
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public string Keywords { get; set; }

    [ColumnDescription("")]
    public string MetaDesc { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int AdminID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }
  }
}
