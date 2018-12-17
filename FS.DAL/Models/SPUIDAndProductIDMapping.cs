using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SPUIDAndProductIDMapping
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }

    [ColumnDescription("")]
    public string CategoryID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public string PinTaiID { get; set; }
  }
}
