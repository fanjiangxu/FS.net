using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductStock
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

    [ColumnDescription("清仓为1，库存为2")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int SKUID { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }
  }
}
