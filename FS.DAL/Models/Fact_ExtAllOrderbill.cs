using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Fact_ExtAllOrderbill
  {

    [ColumnDescription("")]
    public int billId { get; set; }

    [ColumnDescription("")]
    public DateTime addDate { get; set; }

    [ColumnDescription("")]
    public int state { get; set; }

    [ColumnDescription("")]
    public int orderId { get; set; }

    [ColumnDescription("")]
    public DateTime addtime { get; set; }

    [ColumnDescription("")]
    public DateTime PayTime { get; set; }

    [ColumnDescription("")]
    public int orderState { get; set; }

    [ColumnDescription("")]
    public int categoryId { get; set; }

    [ColumnDescription("")]
    public string parentCategoryIds { get; set; }

    [ColumnDescription("")]
    public int siteId { get; set; }

    [ColumnDescription("")]
    public int currency { get; set; }
  }
}
