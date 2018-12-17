using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OptionCategoryProductMapping
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string CategoryID { get; set; }

    [ColumnDescription("")]
    public string ProductID { get; set; }

    [ColumnDescription("")]
    public int OptionSpecial { get; set; }

    [ColumnDescription("")]
    public string OptionValIDs { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }
  }
}
