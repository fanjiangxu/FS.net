using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Inventory
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SKUID { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }

    [ColumnDescription("")]
    public int StockCount { get; set; }

    [ColumnDescription("")]
    public int WarehouseID { get; set; }

    [ColumnDescription("")]
    public string SpecificationJson { get; set; }
  }
}
