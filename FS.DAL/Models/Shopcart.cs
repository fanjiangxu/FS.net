using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Shopcart
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("用户id")]
    public int UserID { get; set; }

    [ColumnDescription("产品id")]
    public int ProductID { get; set; }

    [ColumnDescription("购买数量")]
    public int BuyCount { get; set; }

    [ColumnDescription("添加时间")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("ip")]
    public string IP { get; set; }

    [ColumnDescription("状态")]
    public int State { get; set; }

    [ColumnDescription("备注")]
    public string Remark { get; set; }

    [ColumnDescription("必选区")]
    public string Remark2 { get; set; }

    [ColumnDescription("赠品")]
    public string Gift { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("不用了")]
    public int IsPackage { get; set; }

    [ColumnDescription("不用了")]
    public string CustomID { get; set; }

    [ColumnDescription("语言id")]
    public int LanguageID { get; set; }

    [ColumnDescription("是否删除")]
    public bool IsRemove { get; set; }

    [ColumnDescription("")]
    public int IsSaveForLater { get; set; }

    [ColumnDescription("用户浏览器信息")]
    public string UserAgent { get; set; }

    [ColumnDescription("语言id 新版用")]
    public int CultureID { get; set; }

    [ColumnDescription("产品类型 如赠品，加价购，闪购")]
    public int ItemType { get; set; }

    [ColumnDescription("加入购物车方式 如 buy now ,add to cart ")]
    public int ShopType { get; set; }

    [ColumnDescription("没有登陆的用户的标示")]
    public string UserGuid { get; set; }

    [ColumnDescription("平台 m  www app")]
    public int Platform { get; set; }

    [ColumnDescription("比如搭配销售组id")]
    public int ItemTypeValueID { get; set; }
  }
}
