using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class BpostLog
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public string Ip { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string Sku { get; set; }

    [ColumnDescription("")]
    public string ChineseContentDescription { get; set; }

    [ColumnDescription("")]
    public string OrderNumber { get; set; }

    [ColumnDescription("")]
    public string ProductBarcode { get; set; }

    [ColumnDescription("")]
    public string RecipientName { get; set; }

    [ColumnDescription("")]
    public string RecipientStreet { get; set; }

    [ColumnDescription("")]
    public string RecipientHousenumber { get; set; }

    [ColumnDescription("")]
    public string RecipientBusnumber { get; set; }

    [ColumnDescription("")]
    public string RecipientZipcode { get; set; }

    [ColumnDescription("")]
    public string RecipientCity { get; set; }

    [ColumnDescription("")]
    public string RecipientState { get; set; }

    [ColumnDescription("")]
    public string RecipientCountry { get; set; }

    [ColumnDescription("")]
    public string ItemContent { get; set; }

    [ColumnDescription("")]
    public int ItemCount { get; set; }

    [ColumnDescription("")]
    public string Value { get; set; }

    [ColumnDescription("")]
    public string Currency { get; set; }

    [ColumnDescription("")]
    public string Weight { get; set; }

    [ColumnDescription("")]
    public int adminID { get; set; }
  }
}
