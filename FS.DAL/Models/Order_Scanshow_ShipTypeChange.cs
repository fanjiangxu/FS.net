using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Order_Scanshow_ShipTypeChange
  {

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int IncrentID { get; set; }

    [ColumnDescription("")]
    public string ShipType { get; set; }
  }
}
