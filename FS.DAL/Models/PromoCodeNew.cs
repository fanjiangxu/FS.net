using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PromoCodeNew
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("站点")]
    public int SiteID { get; set; }

    [ColumnDescription("优惠码名称")]
    public string Name { get; set; }

    [ColumnDescription("优惠码类型（现金&折扣）")]
    public int CodeClass { get; set; }

    [ColumnDescription("面值或折扣值")]
    public decimal CodeValue { get; set; }

    [ColumnDescription("最小金额")]
    public decimal MinMoney { get; set; }

    [ColumnDescription("有效天数（系统）")]
    public int ValidDay { get; set; }

    [ColumnDescription("平台")]
    public int PingTai { get; set; }

    [ColumnDescription("开始时间（手动为优惠券的开始时间，系统为优惠码链接的开始时间）")]
    public DateTime StartTime { get; set; }

    [ColumnDescription("同 StartTime")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("使用次数")]
    public int UseIndex { get; set; }

    [ColumnDescription("优惠码说明")]
    public string CodeExplain { get; set; }

    [ColumnDescription("备注")]
    public string Remark { get; set; }

    [ColumnDescription("限制类型（类目，品类，产品）")]
    public int RestrictClass { get; set; }

    [ColumnDescription("根据限制类型存储")]
    public string RestrictID { get; set; }

    [ColumnDescription("语言")]
    public int Language { get; set; }

    [ColumnDescription("优惠码场景（只有在系统中有）")]
    public int CodeScene { get; set; }

    [ColumnDescription("用户级别")]
    public int UserLevel { get; set; }

    [ColumnDescription("优惠码链接")]
    public string CodeUrl { get; set; }

    [ColumnDescription("1 为系统优惠码 2 为手动优惠码")]
    public int Type { get; set; }

    [ColumnDescription("1 删除 0 正常")]
    public int State { get; set; }

    [ColumnDescription("添加时间")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("添加人")]
    public int AddUserID { get; set; }

    [ColumnDescription("是否包含运费")]
    public int IsContainFare { get; set; }

    [ColumnDescription("1 为正在发送的优惠码 0 为不发送")]
    public int SystemState { get; set; }

    [ColumnDescription("订单最小金额")]
    public decimal OrderPriceMin { get; set; }

    [ColumnDescription("订单最大金额")]
    public decimal OrderPriceMax { get; set; }

    [ColumnDescription("")]
    public string Currency { get; set; }

    [ColumnDescription("")]
    public int StartCount { get; set; }

    [ColumnDescription("")]
    public int EndCount { get; set; }

    [ColumnDescription("")]
    public string TogetherUrl { get; set; }
  }
}
