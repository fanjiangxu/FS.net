using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class temp_TBOrder_State_27
  {

    [ColumnDescription("")]
    public int 单号 { get; set; }

    [ColumnDescription("")]
    public string 交易号 { get; set; }

    [ColumnDescription("")]
    public decimal 实际付款 { get; set; }

    [ColumnDescription("")]
    public string 币种 { get; set; }

    [ColumnDescription("")]
    public string 邮箱 { get; set; }

    [ColumnDescription("")]
    public string 电话 { get; set; }

    [ColumnDescription("")]
    public decimal CurrencyRate { get; set; }

    [ColumnDescription("")]
    public int billState { get; set; }

    [ColumnDescription("")]
    public int billID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
