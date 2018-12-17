using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class User_Opinion_Survey
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string EmailID { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int ShippingSpeed { get; set; }

    [ColumnDescription("")]
    public int ProductQuality { get; set; }

    [ColumnDescription("")]
    public int Responsiveness { get; set; }

    [ColumnDescription("")]
    public int WouldYouRecommend { get; set; }

    [ColumnDescription("")]
    public string RemarkContent { get; set; }

    [ColumnDescription("")]
    public int Status { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("0 未处理 1 已处理")]
    public int IsDeal { get; set; }

    [ColumnDescription("")]
    public int Operator { get; set; }

    [ColumnDescription("")]
    public DateTime OperateTime { get; set; }
  }
}
