using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class CW_OrderRefund_Info
  {

    [ColumnDescription("")]
    public string 公司 { get; set; }

    [ColumnDescription("")]
    public string 组织机构 { get; set; }

    [ColumnDescription("")]
    public string 站点 { get; set; }

    [ColumnDescription("")]
    public string 订单号 { get; set; }

    [ColumnDescription("")]
    public string 子订单号 { get; set; }

    [ColumnDescription("")]
    public int 购买数量 { get; set; }

    [ColumnDescription("")]
    public string 退款 { get; set; }

    [ColumnDescription("")]
    public string 币种 { get; set; }

    [ColumnDescription("")]
    public string 汇率 { get; set; }

    [ColumnDescription("")]
    public DateTime 支付时间 { get; set; }

    [ColumnDescription("")]
    public DateTime 退款时间 { get; set; }

    [ColumnDescription("")]
    public string 支付公司 { get; set; }

    [ColumnDescription("")]
    public string 国家 { get; set; }

    [ColumnDescription("")]
    public string 产品规格 { get; set; }

    [ColumnDescription("")]
    public int SKUID { get; set; }

    [ColumnDescription("")]
    public string 产品名称 { get; set; }

    [ColumnDescription("")]
    public string 地址 { get; set; }

    [ColumnDescription("")]
    public string IP地址 { get; set; }
  }
}
