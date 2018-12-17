using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class CouponUserMapping
  {

    [ColumnDescription("主键ID")]
    public int ID { get; set; }

    [ColumnDescription("TB_PromoCodeNew表主键ID")]
    public int CouponID { get; set; }

    [ColumnDescription("用户ID")]
    public int UserID { get; set; }

    [ColumnDescription("订单ID")]
    public int OrderID { get; set; }

    [ColumnDescription("优惠券状态 0未使用 1 已使用")]
    public int State { get; set; }

    [ColumnDescription("修改时间")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string UserGuid { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public string LogContent { get; set; }
  }
}
