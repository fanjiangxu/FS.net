using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class tempMarketPrice
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public decimal MarketPrice { get; set; }

    [ColumnDescription("")]
    public decimal Original { get; set; }
  }
}
