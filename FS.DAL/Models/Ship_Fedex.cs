using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Ship_Fedex
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public decimal WeightFrom { get; set; }

    [ColumnDescription("")]
    public decimal WeightTo { get; set; }

    [ColumnDescription("")]
    public decimal Zone1 { get; set; }

    [ColumnDescription("")]
    public decimal Zone2 { get; set; }

    [ColumnDescription("")]
    public decimal Zone3 { get; set; }

    [ColumnDescription("")]
    public decimal Zone4 { get; set; }

    [ColumnDescription("")]
    public decimal Zone5 { get; set; }

    [ColumnDescription("")]
    public decimal Zone6 { get; set; }

    [ColumnDescription("")]
    public decimal Zone7 { get; set; }

    [ColumnDescription("")]
    public decimal Zone8 { get; set; }

    [ColumnDescription("")]
    public decimal Zone9 { get; set; }

    [ColumnDescription("")]
    public decimal Zone10 { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }
  }
}
