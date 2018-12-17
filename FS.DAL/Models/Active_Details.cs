using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Active_Details
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("外键")]
    public int ActiveListID { get; set; }

    [ColumnDescription("用户范围JSON")]
    public string ScopeUserLevelJSON { get; set; }

    [ColumnDescription("国家范围JSON")]
    public string ScopeUserCountryJSON { get; set; }

    [ColumnDescription("产品数量下限")]
    public int RuleProductCountMin { get; set; }

    [ColumnDescription("产品数量上限")]
    public int RuleProductCountMax { get; set; }

    [ColumnDescription("产品价格下限(存美元)")]
    public decimal RuleProductPriceMin { get; set; }

    [ColumnDescription("产品价格上限(存美元)")]
    public decimal RuleProductPriceMax { get; set; }

    [ColumnDescription("规则条件：And，Or")]
    public int RuleProductCondition { get; set; }

    [ColumnDescription("优惠值")]
    public decimal DiscountValue { get; set; }

    [ColumnDescription("优惠范围")]
    public string DiscountScope1JSON { get; set; }

    [ColumnDescription("优惠范围补充")]
    public string DiscountScope2JSON { get; set; }

    [ColumnDescription("规则状态枚举（正常或暂停）")]
    public int Status { get; set; }

    [ColumnDescription("创建时间")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("创建用户名")]
    public string CreateUserName { get; set; }

    [ColumnDescription("修改时间")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("修改用户名")]
    public string UpdateUserName { get; set; }

    [ColumnDescription("站点id")]
    public int SiteID { get; set; }
  }
}
