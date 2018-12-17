using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderBillPurchase
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public string PrepareDate { get; set; }

    [ColumnDescription("")]
    public DateTime paytime { get; set; }

    [ColumnDescription("")]
    public string maxDate { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public DateTime SendTime { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string Category { get; set; }

    [ColumnDescription("")]
    public string ParentIDs { get; set; }

    [ColumnDescription("")]
    public DateTime ConfirmTime { get; set; }

    [ColumnDescription("")]
    public string ProductNo { get; set; }

    [ColumnDescription("")]
    public string stateName { get; set; }

    [ColumnDescription("")]
    public DateTime normalDate { get; set; }

    [ColumnDescription("")]
    public int DAT { get; set; }

    [ColumnDescription("")]
    public int maxDay { get; set; }

    [ColumnDescription("")]
    public int IsHold { get; set; }

    [ColumnDescription("")]
    public DateTime PurchaseOrdersDate { get; set; }

    [ColumnDescription("")]
    public DateTime RegistrationDate { get; set; }

    [ColumnDescription("")]
    public DateTime QualityDate { get; set; }

    [ColumnDescription("")]
    public int KID { get; set; }
  }
}
