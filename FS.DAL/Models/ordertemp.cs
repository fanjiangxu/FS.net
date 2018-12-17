using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ordertemp
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public DateTime PayTime { get; set; }

    [ColumnDescription("")]
    public int PayType { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string Tx { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }
  }
}
