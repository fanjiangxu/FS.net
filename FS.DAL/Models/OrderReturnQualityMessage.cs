using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderReturnQualityMessage
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int GoodsID { get; set; }

    [ColumnDescription("")]
    public string ImagesPath { get; set; }

    [ColumnDescription("")]
    public string OrderBillID { get; set; }

    [ColumnDescription("")]
    public string QualityStatus { get; set; }

    [ColumnDescription("")]
    public DateTime QualityTime { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }
  }
}
