using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductImagesInfo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int PID { get; set; }

    [ColumnDescription("")]
    public string FileName { get; set; }

    [ColumnDescription("")]
    public string FilePath { get; set; }

    [ColumnDescription("")]
    public decimal Size { get; set; }

    [ColumnDescription("")]
    public decimal Width { get; set; }

    [ColumnDescription("")]
    public decimal Height { get; set; }

    [ColumnDescription("")]
    public int Flag { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
