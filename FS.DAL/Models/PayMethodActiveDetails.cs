using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PayMethodActiveDetails
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int PayMethodActiveID { get; set; }

    [ColumnDescription("")]
    public int DiscountType { get; set; }

    [ColumnDescription("")]
    public decimal DiscountValue { get; set; }

    [ColumnDescription("")]
    public decimal OrderMinMoney { get; set; }

    [ColumnDescription("")]
    public decimal OrderMaxMoney { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string CurrencyName { get; set; }

    [ColumnDescription("")]
    public decimal CurrencyRate { get; set; }
  }
}
