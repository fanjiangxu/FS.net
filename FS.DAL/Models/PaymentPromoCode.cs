using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PaymentPromoCode
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int PaymentTypeID { get; set; }

    [ColumnDescription("")]
    public decimal Money { get; set; }

    [ColumnDescription("")]
    public int LanguageID { get; set; }

    [ColumnDescription("")]
    public DateTime StartTime { get; set; }

    [ColumnDescription("")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int PingTai { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string UserEmail { get; set; }
  }
}
