using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Link_Link
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string WebSite { get; set; }

    [ColumnDescription("")]
    public int PR { get; set; }

    [ColumnDescription("")]
    public int GoogleInclude { get; set; }

    [ColumnDescription("")]
    public string Price { get; set; }

    [ColumnDescription("")]
    public string Type { get; set; }

    [ColumnDescription("")]
    public string PayNumber { get; set; }

    [ColumnDescription("")]
    public string Contact { get; set; }

    [ColumnDescription("")]
    public string KeyWord { get; set; }

    [ColumnDescription("")]
    public string Url { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public string WhoisMail { get; set; }

    [ColumnDescription("")]
    public string Country { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public DateTime EndDate { get; set; }

    [ColumnDescription("")]
    public DateTime CreateDate { get; set; }

    [ColumnDescription("")]
    public string Backup { get; set; }

    [ColumnDescription("")]
    public int Currency { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public int LanguageID { get; set; }

    [ColumnDescription("")]
    public bool IsDeleted { get; set; }

    [ColumnDescription("")]
    public string OutLinkType { get; set; }

    [ColumnDescription("站点类型")]
    public string SiteType { get; set; }

    [ColumnDescription("外链位置")]
    public string OutLinkPosition { get; set; }

    [ColumnDescription("到期流量统计")]
    public int ExpireCount { get; set; }

    [ColumnDescription("产生外链数")]
    public int OutLinkCount { get; set; }

    [ColumnDescription("联系邮箱")]
    public string ContactEmail { get; set; }

    [ColumnDescription("内部联系人")]
    public string AdminName { get; set; }

    [ColumnDescription("内部联系人邮箱")]
    public string AdminEmail { get; set; }
  }
}
