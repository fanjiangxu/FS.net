using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Order_Difference
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("站点ID")]
    public int SiteID { get; set; }

    [ColumnDescription("订单ID")]
    public int OrderID { get; set; }

    [ColumnDescription("差异类型(格式 ,1,2,3,4,5,)")]
    public string DifferenceType { get; set; }

    [ColumnDescription("是否差异")]
    public bool IsDifference { get; set; }

    [ColumnDescription("差异备注")]
    public string Remark { get; set; }

    [ColumnDescription("添加时间")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("逻辑删除状态(1 删除 0 正常)")]
    public int Status { get; set; }

    [ColumnDescription("")]
    public DateTime HandleDate { get; set; }
  }
}
