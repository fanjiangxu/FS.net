using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderChangeMoneyLog
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int AddAndSubtract { get; set; }

    [ColumnDescription("")]
    public decimal beforeMoney { get; set; }

    [ColumnDescription("")]
    public decimal money { get; set; }

    [ColumnDescription("")]
    public decimal ThePrice { get; set; }

    [ColumnDescription("")]
    public DateTime Addtime { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int AdminID { get; set; }
  }
}
