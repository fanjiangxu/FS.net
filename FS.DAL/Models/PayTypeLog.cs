using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PayTypeLog
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("站点ID")]
    public int SiteID { get; set; }

    [ColumnDescription("订单号")]
    public int OrderID { get; set; }

    [ColumnDescription("流水号")]
    public string Tx { get; set; }

    [ColumnDescription("款项")]
    public decimal Amount { get; set; }

    [ColumnDescription("手续费(paypal)")]
    public decimal FeeAmount { get; set; }

    [ColumnDescription("实际收入(paypal)")]
    public decimal SettleAmount { get; set; }

    [ColumnDescription("支付平台状态")]
    public string PaymentStatus { get; set; }

    [ColumnDescription("交易货币")]
    public string CurrentyName { get; set; }

    [ColumnDescription("支付平台名称")]
    public string PaymentName { get; set; }

    [ColumnDescription("备注")]
    public string Remark { get; set; }

    [ColumnDescription("数据在平台的创建时间")]
    public DateTime PayTypeCreateTime { get; set; }

    [ColumnDescription("数据在本地创建时间")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string RefundedTransactionId { get; set; }

    [ColumnDescription("TypeID 默认为-1 0为catch错误 大于0为服务执行sql错误")]
    public int TypeID { get; set; }
  }
}
