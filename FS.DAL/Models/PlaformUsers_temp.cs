using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PlaformUsers_temp
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int PlatformType { get; set; }

    [ColumnDescription("")]
    public string CategoryName { get; set; }

    [ColumnDescription("")]
    public string StoreID { get; set; }

    [ColumnDescription("")]
    public string LoginName { get; set; }

    [ColumnDescription("")]
    public string LoginPwd { get; set; }

    [ColumnDescription("")]
    public int HandleUserID { get; set; }

    [ColumnDescription("")]
    public string HandleUserName { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string AppKey { get; set; }

    [ColumnDescription("")]
    public string AppSecret { get; set; }

    [ColumnDescription("")]
    public string RefreshToken { get; set; }

    [ColumnDescription("")]
    public string StoreUrl { get; set; }

    [ColumnDescription("")]
    public int OrderHandleUserID { get; set; }

    [ColumnDescription("")]
    public int PingTaiID { get; set; }

    [ColumnDescription("")]
    public string StoreIDPak { get; set; }

    [ColumnDescription("")]
    public int ShopId { get; set; }
  }
}
