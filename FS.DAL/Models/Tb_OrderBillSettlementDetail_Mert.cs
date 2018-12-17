using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Tb_OrderBillSettlementDetail_Mert
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int OrderBillID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int OrderRemarkID { get; set; }

    [ColumnDescription("")]
    public string OriginalPrice { get; set; }

    [ColumnDescription("")]
    public string OriginalCost { get; set; }

    [ColumnDescription("")]
    public string Cost { get; set; }

    [ColumnDescription("")]
    public string Currency { get; set; }

    [ColumnDescription("")]
    public string CurrencyRate { get; set; }

    [ColumnDescription("")]
    public int PayChannels { get; set; }

    [ColumnDescription("")]
    public int PaymentMethod { get; set; }

    [ColumnDescription("")]
    public int Category { get; set; }

    [ColumnDescription("")]
    public int Reason { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int LogType { get; set; }

    [ColumnDescription("")]
    public bool IsSystemCreate { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string CreateUserName { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
