using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SizeChart
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string USSize { get; set; }

    [ColumnDescription("")]
    public int UKSize { get; set; }

    [ColumnDescription("")]
    public int EUROPESize { get; set; }

    [ColumnDescription("")]
    public decimal BUST_inches { get; set; }

    [ColumnDescription("")]
    public decimal WAIST_inches { get; set; }

    [ColumnDescription("")]
    public decimal HIP_inches { get; set; }

    [ColumnDescription("")]
    public decimal Shoulder_to_Floor_inches { get; set; }

    [ColumnDescription("")]
    public int BUST_centimeters { get; set; }

    [ColumnDescription("")]
    public int WAIST_centimeters { get; set; }

    [ColumnDescription("")]
    public int HIP_centimeters { get; set; }

    [ColumnDescription("")]
    public int Shoulder_to_Floor_centimeters { get; set; }

    [ColumnDescription("")]
    public string CategoryIDs { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
