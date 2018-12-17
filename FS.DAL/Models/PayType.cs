using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PayType
  {

    [ColumnDescription("")]
    public int PayType1 { get; set; }

    [ColumnDescription("")]
    public int PayMethodID { get; set; }

    [ColumnDescription("")]
    public int PaymentCompanyID { get; set; }

    [ColumnDescription("")]
    public string PayMethod { get; set; }

    [ColumnDescription("")]
    public string PayCompany { get; set; }

    [ColumnDescription("")]
    public string PayTypeName { get; set; }
  }
}
