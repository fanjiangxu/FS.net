using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class KWInfo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime BuyDate { get; set; }

    [ColumnDescription("")]
    public int CategoryLevel { get; set; }

    [ColumnDescription("")]
    public string KW { get; set; }

    [ColumnDescription("")]
    public string Url { get; set; }

    [ColumnDescription("")]
    public DateTime CreateDate { get; set; }
  }
}
