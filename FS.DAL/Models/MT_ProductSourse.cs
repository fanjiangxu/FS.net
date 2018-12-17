using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MT_ProductSourse
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int FormSiteID { get; set; }

    [ColumnDescription("")]
    public int FromProductID { get; set; }

    [ColumnDescription("")]
    public int ToSiteID { get; set; }

    [ColumnDescription("")]
    public int ToProductID { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }
  }
}
