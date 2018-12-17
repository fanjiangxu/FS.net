using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductRelationShip
  {

    [ColumnDescription("")]
    public int PID { get; set; }

    [ColumnDescription("")]
    public string ProductNo { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
