using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderPaypal
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public string Content { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }
  }
}
