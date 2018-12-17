using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class RefundMoneyError
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("支付渠道ID")]
    public int PaymentCompanyID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string CNName { get; set; }

    [ColumnDescription("")]
    public int GroupID { get; set; }

    [ColumnDescription("")]
    public string GroupName { get; set; }
  }
}
