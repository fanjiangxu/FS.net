using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class IS_Inventory
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int DepartmentID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string ProviderProductID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public string Category { get; set; }

    [ColumnDescription("")]
    public string Size { get; set; }

    [ColumnDescription("")]
    public string Color { get; set; }

    [ColumnDescription("")]
    public int InNum { get; set; }

    [ColumnDescription("")]
    public int NowNum { get; set; }

    [ColumnDescription("")]
    public string ProviderID { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public string CargoSpaceNO { get; set; }

    [ColumnDescription("")]
    public int WarningLine { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public int RestockType { get; set; }

    [ColumnDescription("")]
    public int IsRestock { get; set; }

    [ColumnDescription("")]
    public int IsOutofStock { get; set; }

    [ColumnDescription("")]
    public int SloganID { get; set; }

    [ColumnDescription("")]
    public int AllNum { get; set; }

    [ColumnDescription("")]
    public int IsSync { get; set; }
  }
}
