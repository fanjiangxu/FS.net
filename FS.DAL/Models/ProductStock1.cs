using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductStock1
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int CopyID { get; set; }

    [ColumnDescription("")]
    public int Stock { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public string StockRoom { get; set; }

    [ColumnDescription("")]
    public string PrepareDate { get; set; }
  }
}
