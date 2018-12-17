using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Product_PromotionList
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int ChannelID { get; set; }

    [ColumnDescription("")]
    public int AddSourceID { get; set; }

    [ColumnDescription("")]
    public int StartSaleCount { get; set; }

    [ColumnDescription("")]
    public int EndSaleCount { get; set; }

    [ColumnDescription("")]
    public bool PromotionState { get; set; }

    [ColumnDescription("")]
    public string ProductSource { get; set; }

    [ColumnDescription("")]
    public string Quality { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public string Remark1 { get; set; }

    [ColumnDescription("")]
    public int CreateUserID { get; set; }

    [ColumnDescription("")]
    public string CreateUserName { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int StartViews { get; set; }

    [ColumnDescription("")]
    public int EndViews { get; set; }

    [ColumnDescription("")]
    public string PingTai { get; set; }

    [ColumnDescription("")]
    public int LanguageID { get; set; }
  }
}
