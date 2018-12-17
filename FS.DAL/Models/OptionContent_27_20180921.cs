using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OptionContent_27_20180921
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OptionContentID { get; set; }

    [ColumnDescription("")]
    public int OptionValID { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int isDefault { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public int state { get; set; }

    [ColumnDescription("")]
    public int PrepareDate { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }
  }
}
