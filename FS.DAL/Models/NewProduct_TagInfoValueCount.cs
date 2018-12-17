using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class NewProduct_TagInfoValueCount
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ValueCount { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }
  }
}
