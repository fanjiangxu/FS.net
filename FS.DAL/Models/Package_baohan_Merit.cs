using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Package_baohan_Merit
  {

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string DeliveryMonth { get; set; }
  }
}
