using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Category
  {

    [ColumnDescription("主键标识")]
    public int ID { get; set; }

    [ColumnDescription("父id")]
    public int ParentID { get; set; }

    [ColumnDescription("名称")]
    public string Name { get; set; }

    [ColumnDescription("中文名称")]
    public string CNName { get; set; }

    [ColumnDescription("具有产品数")]
    public int ProductCount { get; set; }

    [ColumnDescription("父类关系")]
    public string ParentIDs { get; set; }

    [ColumnDescription("排序")]
    public int Sort { get; set; }

    [ColumnDescription("logo 地址")]
    public string Logo { get; set; }

    [ColumnDescription("")]
    public int ShowType { get; set; }

    [ColumnDescription("")]
    public int FakeLevel { get; set; }

    [ColumnDescription("状态 1 是正常 0 是不显示必选区 -4 删除")]
    public int State { get; set; }

    [ColumnDescription("站点编号")]
    public int SiteID { get; set; }

    [ColumnDescription("分类的标题 seo 用")]
    public string TitleTags { get; set; }

    [ColumnDescription("分类meta关键词 seo 用")]
    public string KeywordsTags { get; set; }

    [ColumnDescription("分类meta描述 seo 用")]
    public string DescriptionTags { get; set; }

    [ColumnDescription("分类描述")]
    public string Description { get; set; }

    [ColumnDescription("")]
    public decimal CustomPrice { get; set; }

    [ColumnDescription("产品数临时字段")]
    public int ProductCount1 { get; set; }

    [ColumnDescription("")]
    public int CategoryNameID { get; set; }

    [ColumnDescription("是否在导航显示")]
    public bool IsShow { get; set; }

    [ColumnDescription("域名")]
    public string Domain { get; set; }

    [ColumnDescription("分类url ")]
    public string defaultUrl { get; set; }

    [ColumnDescription("")]
    public string FirstWord { get; set; }

    [ColumnDescription("分类名标识 用于url 固定")]
    public string urlSign { get; set; }

    [ColumnDescription("")]
    public int ImageWidth { get; set; }

    [ColumnDescription("")]
    public int ImageHeight { get; set; }

    [ColumnDescription("")]
    public int ImageQuality { get; set; }

    [ColumnDescription("")]
    public int IsUserCustomImage { get; set; }

    [ColumnDescription("")]
    public string RedirectUrl { get; set; }

    [ColumnDescription("")]
    public string RedirectUrl301 { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public string LogoDesc { get; set; }
  }
}
