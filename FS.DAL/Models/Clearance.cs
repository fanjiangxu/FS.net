using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Clearance
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int OldProductID { get; set; }

    [ColumnDescription("")]
    public string SizeInfo { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int Quantity { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int Clearstate { get; set; }

    [ColumnDescription("")]
    public string ClearStockCategoryID { get; set; }

    [ColumnDescription("")]
    public int Material { get; set; }

    [ColumnDescription("")]
    public string Num { get; set; }
  }
}
