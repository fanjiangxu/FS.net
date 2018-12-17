using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Blogger_Stock
  {

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int StockId { get; set; }

    [ColumnDescription("")]
    public int Stock { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public string PrepareDate { get; set; }
  }
}
