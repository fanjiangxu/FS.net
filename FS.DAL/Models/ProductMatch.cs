using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductMatch
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public string Description { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int AddUserID { get; set; }

    [ColumnDescription("")]
    public string Code { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string Img { get; set; }

    [ColumnDescription("")]
    public DateTime StartDate { get; set; }

    [ColumnDescription("")]
    public int StartTime { get; set; }

    [ColumnDescription("")]
    public int allDays { get; set; }

    [ColumnDescription("1:显示，0:手动下架(失效)")]
    public int IsShow { get; set; }
  }
}
