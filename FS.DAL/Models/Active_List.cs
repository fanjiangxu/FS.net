using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Active_List
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("外键")]
    public int ActiveNameID { get; set; }

    [ColumnDescription("细则名称")]
    public string Name { get; set; }

    [ColumnDescription("活动开始时间")]
    public DateTime StartTime { get; set; }

    [ColumnDescription("活动结束时间")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("包含分类（品类或类目）")]
    public string ScopeFenLeiIncludeJSON { get; set; }

    [ColumnDescription("排除分类（品类或类目），没有值就是没有排除的品类或类目")]
    public string ScopeFenLeiExcludeJSON { get; set; }

    [ColumnDescription("分类（类目或品类）")]
    public int ScopeLeiMuOrPinLei { get; set; }

    [ColumnDescription("包含产品")]
    public string ScopeProductIncludeJSON { get; set; }

    [ColumnDescription("排除产品")]
    public string ScopeProductExcludeJSON { get; set; }

    [ColumnDescription("产品（SPUID或SKUID）")]
    public int ScopeProductSKUorSPU { get; set; }

    [ColumnDescription("")]
    public string ScopeBrandIncludeJSON { get; set; }

    [ColumnDescription("")]
    public string ScopeStyleIncludeJSON { get; set; }

    [ColumnDescription("当前使用的优惠方式，枚举（按金额包邮，按折扣包邮；按购物车中满足条件的产品打折，按购物车中满足条件的产品减钱，按产品总价定额定价；按SKU赠送产品；满M件送N件）")]
    public int DiscountTypeUse { get; set; }

    [ColumnDescription("使用当前的优惠方式，要排除其他的优惠方式，如果没有值表示没有排除的优惠方式。")]
    public string DiscountTypeExcludeJSON { get; set; }

    [ColumnDescription("活动使用平台枚举：PC，M，APP")]
    public string PlatformJSON { get; set; }

    [ColumnDescription("活动优先级别（排序规则：值越大级别越高）")]
    public int Priority { get; set; }

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

    [ColumnDescription("是否是测试，1为测试。0为正式")]
    public int IsTest { get; set; }

    [ColumnDescription("参加活动的语言")]
    public string CultureIDJson { get; set; }

    [ColumnDescription("站点id")]
    public int SiteID { get; set; }
  }
}
