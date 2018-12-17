using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PriceList_Fr
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int StartNum { get; set; }

    [ColumnDescription("")]
    public int EndNum { get; set; }

    [ColumnDescription("")]
    public decimal Discount { get; set; }

    [ColumnDescription("")]
    public string PrepareDate { get; set; }

    [ColumnDescription("")]
    public string ParentIDs { get; set; }

    [ColumnDescription("")]
    public int ParentID { get; set; }
  }
}
