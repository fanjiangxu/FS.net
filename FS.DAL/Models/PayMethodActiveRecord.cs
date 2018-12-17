using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PayMethodActiveRecord
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int PaymentTypeID { get; set; }

    [ColumnDescription("")]
    public int PayMethodActiveID { get; set; }

    [ColumnDescription("")]
    public decimal DiscountMoney { get; set; }

    [ColumnDescription("")]
    public decimal USDDiscountMoney { get; set; }
  }
}
