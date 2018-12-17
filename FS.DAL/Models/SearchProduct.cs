using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SearchProduct
  {

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public string SearchText { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }
  }
}
