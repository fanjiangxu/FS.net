using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductCostPrice
  {

    [ColumnDescription("")]
    public int PID { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }
  }
}
