using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class temp_order_sumaitong1111
  {

    [ColumnDescription("")]
    public int 订单号 { get; set; }

    [ColumnDescription("")]
    public int 子订单号 { get; set; }

    [ColumnDescription("")]
    public int 购买数量 { get; set; }

    [ColumnDescription("")]
    public DateTime 付款时间 { get; set; }

    [ColumnDescription("")]
    public string 国家 { get; set; }

    [ColumnDescription("")]
    public string CategoryName { get; set; }

    [ColumnDescription("")]
    public string PlatSiteName { get; set; }

    [ColumnDescription("")]
    public int 店铺 { get; set; }

    [ColumnDescription("")]
    public string 登陆邮箱 { get; set; }

    [ColumnDescription("")]
    public string 速卖通订单号 { get; set; }

    [ColumnDescription("")]
    public string 剩余发货时间 { get; set; }

    [ColumnDescription("")]
    public string 子订单状态 { get; set; }

    [ColumnDescription("")]
    public int Spuid { get; set; }

    [ColumnDescription("")]
    public int SkuID { get; set; }

    [ColumnDescription("")]
    public string 货号 { get; set; }

    [ColumnDescription("")]
    public string 物流方式 { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
