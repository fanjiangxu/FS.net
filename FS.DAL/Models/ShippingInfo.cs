using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ShippingInfo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Product_HSCNName { get; set; }

    [ColumnDescription("")]
    public string Product_HSName { get; set; }

    [ColumnDescription("")]
    public string Product_HS { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public string Price { get; set; }

    [ColumnDescription("")]
    public int OrderBy { get; set; }

    [ColumnDescription("")]
    public int parentId { get; set; }
  }
}
