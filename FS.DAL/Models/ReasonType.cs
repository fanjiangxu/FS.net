using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ReasonType
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string ContentText { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
