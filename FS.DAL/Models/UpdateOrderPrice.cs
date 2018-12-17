using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UpdateOrderPrice
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public int AdminId { get; set; }

    [ColumnDescription("")]
    public int OrderId { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public string OrigPrice { get; set; }

    [ColumnDescription("")]
    public string NewPrice { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int changeType { get; set; }

    [ColumnDescription("")]
    public string order_bill_id { get; set; }

    [ColumnDescription("")]
    public string order_bill_type { get; set; }

    [ColumnDescription("")]
    public string adminIp { get; set; }
  }
}
