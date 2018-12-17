using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Payment_Information
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int Company { get; set; }

    [ColumnDescription("")]
    public decimal TotalMoney { get; set; }

    [ColumnDescription("")]
    public string Currency { get; set; }

    [ColumnDescription("")]
    public int PaymentStatus { get; set; }

    [ColumnDescription("")]
    public DateTime SettlementDate { get; set; }

    [ColumnDescription("")]
    public string CreateUserName { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string UpdateUserName { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public string CardType { get; set; }
  }
}
