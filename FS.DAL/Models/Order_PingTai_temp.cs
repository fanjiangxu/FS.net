using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Order_PingTai_temp
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderId { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public int IsPingTai { get; set; }

    [ColumnDescription("")]
    public int AddUser { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int PingTaiID { get; set; }

    [ColumnDescription("")]
    public int StoreID { get; set; }

    [ColumnDescription("")]
    public string FromCountryCode { get; set; }

    [ColumnDescription("")]
    public string PlatSiteName { get; set; }

    [ColumnDescription("")]
    public int StoreIDPak { get; set; }

    [ColumnDescription("")]
    public int PingTaiIDPak { get; set; }

    [ColumnDescription("")]
    public int ShopID { get; set; }
  }
}
