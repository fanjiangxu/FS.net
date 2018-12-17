using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductList
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("标题")]
    public string Title { get; set; }

    [ColumnDescription("简短描述")]
    public string Summary { get; set; }

    [ColumnDescription("图片路径")]
    public string Images { get; set; }

    [ColumnDescription("分类id")]
    public string CategoryIDs { get; set; }

    [ColumnDescription("分类的树形结构")]
    public string ParentIDs { get; set; }

    [ColumnDescription("单位")]
    public int Unit { get; set; }

    [ColumnDescription("最小购买量")]
    public int MinNum { get; set; }

    [ColumnDescription("仿货级别")]
    public int FakeLevel { get; set; }

    [ColumnDescription("状态 0为下架 1 为上架,2 是促销,3 是清仓,4是预售,-4 是删除")]
    public int State { get; set; }

    [ColumnDescription("是否免运费")]
    public int Shipping { get; set; }

    [ColumnDescription("浏览量")]
    public int Views { get; set; }

    [ColumnDescription("销售量")]
    public int SaleCount { get; set; }

    [ColumnDescription("原价")]
    public decimal Original { get; set; }

    [ColumnDescription("评论数")]
    public int Review { get; set; }

    [ColumnDescription("总评分")]
    public int ReviewPoint { get; set; }

    [ColumnDescription("产品重量")]
    public decimal ProductWeight { get; set; }

    [ColumnDescription("价格")]
    public decimal Price { get; set; }

    [ColumnDescription("市场价")]
    public decimal MarketPrice { get; set; }

    [ColumnDescription("添加时间")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("站点编号")]
    public int SiteID { get; set; }

    [ColumnDescription("尺寸")]
    public int Size { get; set; }

    [ColumnDescription("排序")]
    public int Sort { get; set; }

    [ColumnDescription("促销结束时间")]
    public DateTime EndDate { get; set; }

    [ColumnDescription("")]
    public int oldID { get; set; }

    [ColumnDescription("折扣")]
    public decimal Discount { get; set; }

    [ColumnDescription("是否是新品")]
    public int IsNew { get; set; }

    [ColumnDescription("")]
    public DateTime OutDate { get; set; }

    [ColumnDescription("新品时间")]
    public DateTime IsNewDate { get; set; }

    [ColumnDescription("")]
    public string Ratio { get; set; }

    [ColumnDescription("影棚id")]
    public int StudioID { get; set; }

    [ColumnDescription("")]
    public int SortingStatus { get; set; }

    [ColumnDescription("url 标识")]
    public string TitleUrl { get; set; }

    [ColumnDescription("是否是热卖")]
    public int IsHot { get; set; }

    [ColumnDescription("是否是24小时快发产品")]
    public int Is24H { get; set; }

    [ColumnDescription("")]
    public int PmsCategoryID { get; set; }

    [ColumnDescription("")]
    public int TeamLevel { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }

    [ColumnDescription("")]
    public int MaxNum { get; set; }

    [ColumnDescription("")]
    public int IsEngraved { get; set; }

    [ColumnDescription("")]
    public int IsGraphCustomization { get; set; }
  }
}
