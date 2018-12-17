using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ManageOrderBillBeyond
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int Siteid { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public string SiteName { get; set; }

    [ColumnDescription("")]
    public string CNName { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public DateTime PayTime { get; set; }

    [ColumnDescription("")]
    public int providerid { get; set; }

    [ColumnDescription("")]
    public string PrepareDate { get; set; }

    [ColumnDescription("")]
    public DateTime ActualSendDate { get; set; }

    [ColumnDescription("")]
    public DateTime StockTime { get; set; }

    [ColumnDescription("")]
    public DateTime CheckTime { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public int PrepareStartDate { get; set; }

    [ColumnDescription("")]
    public int PrepareEndDate { get; set; }

    [ColumnDescription("")]
    public int ProductUrlID { get; set; }

    [ColumnDescription("")]
    public int OrderBillAreState { get; set; }

    [ColumnDescription("")]
    public int PurchasingAreState { get; set; }

    [ColumnDescription("")]
    public int AdminId { get; set; }

    [ColumnDescription("")]
    public int UnHold { get; set; }
  }
}
