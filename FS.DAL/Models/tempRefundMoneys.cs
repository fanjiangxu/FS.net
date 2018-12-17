using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class tempRefundMoneys
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public int siteid { get; set; }

    [ColumnDescription("")]
    public decimal RefundMoney { get; set; }

    [ColumnDescription("")]
    public decimal CurrencyRate { get; set; }

    [ColumnDescription("")]
    public DateTime paytime { get; set; }
  }
}
