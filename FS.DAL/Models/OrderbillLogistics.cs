using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderbillLogistics
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int AdminID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int Siteid { get; set; }

    [ColumnDescription("")]
    public int OrderBillID { get; set; }

    [ColumnDescription("")]
    public string Text { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }
  }
}
