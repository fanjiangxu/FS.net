using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SKUUnValid
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SKUID { get; set; }

    [ColumnDescription("")]
    public int OptionValID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int OptionID { get; set; }

    [ColumnDescription("")]
    public int OptionContentID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
