using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PromoCode
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string PromoCode1 { get; set; }

    [ColumnDescription("")]
    public decimal FaceValue { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public DateTime EndDate { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int KID { get; set; }

    [ColumnDescription("")]
    public int CreateOrderID { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int DoUserID { get; set; }

    [ColumnDescription("")]
    public DateTime UserDate { get; set; }

    [ColumnDescription("")]
    public decimal MinTotal { get; set; }

    [ColumnDescription("")]
    public decimal MaxTotal { get; set; }

    [ColumnDescription("")]
    public int CodeAction { get; set; }
  }
}
