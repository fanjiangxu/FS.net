using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Bonus
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public DateTime StartTime { get; set; }

    [ColumnDescription("")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("")]
    public bool State { get; set; }

    [ColumnDescription("")]
    public decimal Money { get; set; }

    [ColumnDescription("")]
    public string PromoCode { get; set; }

    [ColumnDescription("")]
    public DateTime UseDate { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public decimal InitialValue { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int CreateOrderID { get; set; }

    [ColumnDescription("")]
    public int UseredOrderID { get; set; }
  }
}
