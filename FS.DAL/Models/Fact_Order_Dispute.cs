using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Fact_Order_Dispute
  {

    [ColumnDescription("月份")]
    public int OrderMonth { get; set; }

    [ColumnDescription("")]
    public int DisputeMonth { get; set; }

    [ColumnDescription("产品ID")]
    public int ProductId { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }

    [ColumnDescription("产品线ID")]
    public int ProductLineId { get; set; }

    [ColumnDescription("当月争议子单数")]
    public int DisputeBillCount { get; set; }

    [ColumnDescription("已支付子单数")]
    public int SellBillCount { get; set; }
  }
}
