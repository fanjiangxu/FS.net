using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MaterialColorMapping
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Material { get; set; }

    [ColumnDescription("")]
    public string ColorValue { get; set; }

    [ColumnDescription("")]
    public int ColourScheme { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
