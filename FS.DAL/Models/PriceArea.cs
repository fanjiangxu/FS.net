using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PriceArea
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int CID { get; set; }

    [ColumnDescription("")]
    public decimal PriceBegin { get; set; }

    [ColumnDescription("")]
    public decimal PriceEnd { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
