using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class product_NewTitle
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public string title { get; set; }

    [ColumnDescription("")]
    public string title1 { get; set; }
  }
}
