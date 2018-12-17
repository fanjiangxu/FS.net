using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductTestSection
  {

    [ColumnDescription("产品试款表 分站为主键ID")]
    public int ID { get; set; }

    [ColumnDescription("产品ID")]
    public int ProductID { get; set; }

    [ColumnDescription("产品必选区")]
    public string Required { get; set; }

    [ColumnDescription("用户邮箱")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("用户点击添加或者BuyNow的次数(购物车)")]
    public int AddCartCount { get; set; }

    [ColumnDescription("用户点击提交信息的次数(购物车)")]
    public int SubmitCount { get; set; }

    [ColumnDescription("用户IP")]
    public string IP { get; set; }

    [ColumnDescription("平台(0为PC端 1为手机端)")]
    public int Status { get; set; }

    [ColumnDescription("站点ID")]
    public string SiteID { get; set; }

    [ColumnDescription("添加时间")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int IsSend { get; set; }
  }
}
