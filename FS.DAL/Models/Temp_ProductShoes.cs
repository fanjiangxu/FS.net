using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Temp_ProductShoes
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public decimal Original { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
