using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SendOrder_PingTai
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public string Tx { get; set; }

    [ColumnDescription("")]
    public int PingTaiID { get; set; }

    [ColumnDescription("")]
    public int StoreID { get; set; }

    [ColumnDescription("")]
    public string ShippingType { get; set; }

    [ColumnDescription("")]
    public string ExpressType { get; set; }

    [ColumnDescription("")]
    public string ShipNo { get; set; }

    [ColumnDescription("")]
    public int PushState { get; set; }

    [ColumnDescription("")]
    public int HandleState { get; set; }

    [ColumnDescription("")]
    public int ErrorCount { get; set; }

    [ColumnDescription("")]
    public string SendType { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public DateTime PushDate { get; set; }

    [ColumnDescription("")]
    public string trackingWebsite { get; set; }

    [ColumnDescription("")]
    public int FalseShipNo { get; set; }

    [ColumnDescription("")]
    public int IfModife { get; set; }

    [ColumnDescription("")]
    public int PushUserID { get; set; }
  }
}
