using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ShipPrice
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int Zone { get; set; }

    [ColumnDescription("")]
    public decimal StandardPrice { get; set; }

    [ColumnDescription("")]
    public decimal AddPrice { get; set; }

    [ColumnDescription("")]
    public int LogisticsID { get; set; }

    [ColumnDescription("")]
    public decimal BasePrice { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
