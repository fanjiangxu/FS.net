using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ColorInfo
  {

    [ColumnDescription("")]
    public string Color_Cn { get; set; }

    [ColumnDescription("")]
    public string Color_En { get; set; }

    [ColumnDescription("")]
    public string Color_Fr { get; set; }

    [ColumnDescription("")]
    public string Color_Es { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }
  }
}
