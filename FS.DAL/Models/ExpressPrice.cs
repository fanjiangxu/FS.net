using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ExpressPrice
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ExpressID { get; set; }

    [ColumnDescription("")]
    public string Country { get; set; }

    [ColumnDescription("")]
    public string Country2 { get; set; }

    [ColumnDescription("")]
    public int Zone { get; set; }

    [ColumnDescription("")]
    public int M { get; set; }

    [ColumnDescription("")]
    public int D { get; set; }

    [ColumnDescription("")]
    public int Additional { get; set; }

    [ColumnDescription("")]
    public int EmsType { get; set; }
  }
}
