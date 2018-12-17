using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductStockOptionMapping
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OptionID { get; set; }

    [ColumnDescription("")]
    public int OptionValue { get; set; }

    [ColumnDescription("")]
    public int ProductStockID { get; set; }
  }
}
