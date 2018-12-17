using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class LoanListQuery
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string orderId { get; set; }

    [ColumnDescription("")]
    public string childOrderId { get; set; }

    [ColumnDescription("")]
    public string loanStatus { get; set; }

    [ColumnDescription("")]
    public DateTime releasedDatetime { get; set; }

    [ColumnDescription("")]
    public string waitLoanReson { get; set; }

    [ColumnDescription("")]
    public string affiliateCommission { get; set; }

    [ColumnDescription("")]
    public string amount { get; set; }

    [ColumnDescription("")]
    public string escrowFee { get; set; }

    [ColumnDescription("")]
    public string loanAmount { get; set; }

    [ColumnDescription("")]
    public string realLoanAmount { get; set; }

    [ColumnDescription("")]
    public string realRefundAmount { get; set; }

    [ColumnDescription("")]
    public string refundAmount { get; set; }

    [ColumnDescription("")]
    public string Currency { get; set; }
  }
}
