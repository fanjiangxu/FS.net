using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderOrBillState
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderOrBillID { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int Siteid { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }
  }
}
