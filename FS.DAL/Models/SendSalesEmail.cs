using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SendSalesEmail
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string AddDate { get; set; }

    [ColumnDescription("1:到货通知邮件2:降价通知邮件")]
    public int EmailType { get; set; }

    [ColumnDescription("1:用户订阅2:系统订阅")]
    public int EmailSource { get; set; }

    [ColumnDescription("1:已发送2:未发送")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public decimal CurrencyPrice { get; set; }

    [ColumnDescription("")]
    public string CurrencyName { get; set; }

    [ColumnDescription("")]
    public decimal ProductPrice { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
