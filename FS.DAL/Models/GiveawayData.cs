using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class GiveawayData
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public DateTime AdminAddDate { get; set; }

    [ColumnDescription("")]
    public string WayName { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public string SiteName { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int OrderBillId { get; set; }

    [ColumnDescription("")]
    public int ProductId { get; set; }

    [ColumnDescription("")]
    public string CNName { get; set; }

    [ColumnDescription("")]
    public string PrepareDate { get; set; }

    [ColumnDescription("")]
    public int MaxPrepareDate { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public DateTime PayTime { get; set; }

    [ColumnDescription("")]
    public DateTime CheckTime { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public int PrepareStartDate { get; set; }

    [ColumnDescription("")]
    public int PrepareEndDate { get; set; }

    [ColumnDescription("")]
    public int OrderBillAreState { get; set; }

    [ColumnDescription("")]
    public int PurchasingAreState { get; set; }

    [ColumnDescription("")]
    public decimal Shipping { get; set; }

    [ColumnDescription("")]
    public string ShipType { get; set; }

    [ColumnDescription("")]
    public string ShipNo { get; set; }

    [ColumnDescription("")]
    public decimal PurchasingPrice { get; set; }

    [ColumnDescription("")]
    public DateTime ActualSendDate { get; set; }

    [ColumnDescription("")]
    public DateTime DateOfReceipt { get; set; }

    [ColumnDescription("")]
    public string Url { get; set; }

    [ColumnDescription("")]
    public string DataLog { get; set; }

    [ColumnDescription("")]
    public int OrderBillStateInt { get; set; }

    [ColumnDescription("")]
    public int AdminID { get; set; }
  }
}
