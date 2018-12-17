using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ColorPanel
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Chinese { get; set; }

    [ColumnDescription("")]
    public string English { get; set; }

    [ColumnDescription("")]
    public string Spanish { get; set; }

    [ColumnDescription("")]
    public string French { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int siteid { get; set; }
  }
}
