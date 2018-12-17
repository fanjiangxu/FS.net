using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductComment
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("用户id")]
    public int UserID { get; set; }

    [ColumnDescription("产品id")]
    public int ProductID { get; set; }

    [ColumnDescription("添加时间")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("内容")]
    public string Content { get; set; }

    [ColumnDescription("星级")]
    public int Level { get; set; }

    [ColumnDescription("ip地址")]
    public string IP { get; set; }

    [ColumnDescription("状态 1 为审核通过 0为等待审核 -1 为审核不通过")]
    public int State { get; set; }

    [ColumnDescription("用户名")]
    public string UserName { get; set; }

    [ColumnDescription("用户邮箱")]
    public string Email { get; set; }

    [ColumnDescription("回复内容")]
    public string Reply { get; set; }

    [ColumnDescription("标题")]
    public string Title { get; set; }

    [ColumnDescription("回复人")]
    public int replayUserID { get; set; }

    [ColumnDescription("订单编号")]
    public int OrderID { get; set; }

    [ColumnDescription("子单编号")]
    public int BillID { get; set; }

    [ColumnDescription("评论时间")]
    public DateTime CommentDate { get; set; }

    [ColumnDescription("站点编号")]
    public int SiteID { get; set; }

    [ColumnDescription("回复时间")]
    public DateTime ReplyDate { get; set; }

    [ColumnDescription("图片地址")]
    public string images { get; set; }

    [ColumnDescription("运输速度评分")]
    public int ShipSpeed { get; set; }

    [ColumnDescription("服务质量评分")]
    public int CustomerService { get; set; }

    [ColumnDescription("产品质量")]
    public int Quality { get; set; }

    [ColumnDescription("支持数")]
    public int Support { get; set; }

    [ColumnDescription("反对数")]
    public int Against { get; set; }

    [ColumnDescription("评论或者咨询 1 为评论 2是咨询")]
    public int CommentType { get; set; }

    [ColumnDescription("")]
    public int ConsultingType { get; set; }

    [ColumnDescription("")]
    public int GoodISbad { get; set; }

    [ColumnDescription("产品分类关系")]
    public string ParentIDs { get; set; }

    [ColumnDescription("")]
    public int IsImport { get; set; }

    [ColumnDescription("是否是投诉")]
    public int IsComplaint { get; set; }

    [ColumnDescription("语言")]
    public int LanguageID { get; set; }

    [ColumnDescription("")]
    public string Style { get; set; }

    [ColumnDescription("")]
    public string Age { get; set; }

    [ColumnDescription("")]
    public string HideImage { get; set; }

    [ColumnDescription("")]
    public int HandleType { get; set; }

    [ColumnDescription("")]
    public DateTime SyncDate { get; set; }
  }
}
