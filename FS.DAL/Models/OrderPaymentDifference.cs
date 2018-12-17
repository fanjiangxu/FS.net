using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderPaymentDifference
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int PaymentCompanyID { get; set; }

    [ColumnDescription("")]
    public string SettlementDate { get; set; }

    [ColumnDescription("")]
    public string CurrenyName { get; set; }

    [ColumnDescription("")]
    public decimal DifferencePrice { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public decimal CmsPrice { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }
  }
}
