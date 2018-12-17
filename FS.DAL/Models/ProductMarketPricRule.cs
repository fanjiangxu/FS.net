using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductMarketPricRule
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("站点ID")]
    public int SiteID { get; set; }

    [ColumnDescription("品类ID")]
    public int PmsCategoryID { get; set; }

    [ColumnDescription("品类名称")]
    public string PmsCategoryName { get; set; }

    [ColumnDescription("最小倍率")]
    public decimal MinMultiplying { get; set; }

    [ColumnDescription("最大倍率")]
    public decimal MaxMultiplying { get; set; }

    [ColumnDescription("创建人")]
    public string CreateUserName { get; set; }

    [ColumnDescription("创建时间")]
    public DateTime CreateDateTime { get; set; }

    [ColumnDescription("修改时间")]
    public DateTime HandleTime { get; set; }

    [ColumnDescription("修改人")]
    public string HandleUserName { get; set; }
  }
}
