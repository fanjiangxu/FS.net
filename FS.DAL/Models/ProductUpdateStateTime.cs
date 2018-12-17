using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductUpdateStateTime
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public DateTime beginDate { get; set; }

    [ColumnDescription("")]
    public string beginTime { get; set; }

    [ColumnDescription("")]
    public string SiteID { get; set; }

    [ColumnDescription("")]
    public string IsOnSale { get; set; }
  }
}
