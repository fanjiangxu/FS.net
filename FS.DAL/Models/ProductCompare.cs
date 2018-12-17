using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductCompare
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID1 { get; set; }

    [ColumnDescription("")]
    public int ProductID2 { get; set; }

    [ColumnDescription("")]
    public int Vote1 { get; set; }

    [ColumnDescription("")]
    public int Vote2 { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }
  }
}
