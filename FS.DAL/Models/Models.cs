using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Models
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string Height { get; set; }

    [ColumnDescription("")]
    public string Bust { get; set; }

    [ColumnDescription("")]
    public string Waist { get; set; }

    [ColumnDescription("")]
    public string Hips { get; set; }

    [ColumnDescription("")]
    public string Size { get; set; }

    [ColumnDescription("")]
    public string Images { get; set; }

    [ColumnDescription("")]
    public string Category { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
