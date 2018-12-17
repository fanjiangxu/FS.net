using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductInterest
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int InterProductID { get; set; }

    [ColumnDescription("")]
    public int SaleCount { get; set; }

    [ColumnDescription("")]
    public int ViewsCount { get; set; }

    [ColumnDescription("")]
    public int Level { get; set; }
  }
}
