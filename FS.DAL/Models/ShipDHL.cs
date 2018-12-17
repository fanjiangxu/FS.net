using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ShipDHL
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string WeightFrom { get; set; }

    [ColumnDescription("")]
    public string WeightTO { get; set; }

    [ColumnDescription("")]
    public string Zone1 { get; set; }

    [ColumnDescription("")]
    public string Zone2 { get; set; }

    [ColumnDescription("")]
    public string Zone3 { get; set; }

    [ColumnDescription("")]
    public string Zone4 { get; set; }

    [ColumnDescription("")]
    public string Zone5 { get; set; }

    [ColumnDescription("")]
    public string Zone6 { get; set; }

    [ColumnDescription("")]
    public string Zone7 { get; set; }

    [ColumnDescription("")]
    public string Zone8 { get; set; }

    [ColumnDescription("")]
    public string Zone9 { get; set; }

    [ColumnDescription("")]
    public string Zone10 { get; set; }

    [ColumnDescription("")]
    public string Zone11 { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
