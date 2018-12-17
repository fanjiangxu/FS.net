using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Buyers_Info
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string ProductImage { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public string Content { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int ActivitID { get; set; }

    [ColumnDescription("")]
    public string TagStr { get; set; }

    [ColumnDescription("")]
    public string UserTagStr { get; set; }

    [ColumnDescription("")]
    public int Status { get; set; }

    [ColumnDescription("")]
    public bool IsShow { get; set; }

    [ColumnDescription("")]
    public bool IsDelete { get; set; }

    [ColumnDescription("")]
    public int productID { get; set; }

    [ColumnDescription("")]
    public int NotPassReasonID { get; set; }

    [ColumnDescription("")]
    public int PointChanCount { get; set; }
  }
}
