using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderWestern
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public string Num { get; set; }

    [ColumnDescription("")]
    public string SendName { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public DateTime SendDate { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string Num2 { get; set; }

    [ColumnDescription("")]
    public string FirstName { get; set; }

    [ColumnDescription("")]
    public string Currency { get; set; }

    [ColumnDescription("")]
    public string Country { get; set; }

    [ColumnDescription("")]
    public string LastName { get; set; }
  }
}
