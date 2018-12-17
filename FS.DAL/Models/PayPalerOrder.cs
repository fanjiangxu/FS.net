using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PayPalerOrder
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public string Phone { get; set; }

    [ColumnDescription("")]
    public string CName { get; set; }

    [ColumnDescription("")]
    public string Address { get; set; }

    [ColumnDescription("")]
    public string Cartstring { get; set; }

    [ColumnDescription("")]
    public DateTime Time { get; set; }

    [ColumnDescription("")]
    public string Token { get; set; }

    [ColumnDescription("")]
    public string PayerID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
