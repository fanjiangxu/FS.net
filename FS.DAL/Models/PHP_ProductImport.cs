using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PHP_ProductImport
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int NewProductID { get; set; }

    [ColumnDescription("")]
    public DateTime ImportDate { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int MagentoState { get; set; }

    [ColumnDescription("")]
    public string DoLog { get; set; }
  }
}
