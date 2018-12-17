using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UserCustomInfo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Images { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string Bust { get; set; }

    [ColumnDescription("")]
    public string Waist { get; set; }

    [ColumnDescription("")]
    public string Hips { get; set; }

    [ColumnDescription("")]
    public string ToFloor { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int Stutas { get; set; }

    [ColumnDescription("")]
    public int OrderId { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public decimal price { get; set; }

    [ColumnDescription("")]
    public int Customttype { get; set; }
  }
}
