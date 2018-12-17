using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SheetStock
  {

    [ColumnDescription("")]
    public string Tx { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string 执御 { get; set; }

    [ColumnDescription("")]
    public string SKUID { get; set; }

    [ColumnDescription("")]
    public string SendNum { get; set; }

    [ColumnDescription("")]
    public string StockNum { get; set; }

    [ColumnDescription("")]
    public string log { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }

    [ColumnDescription("")]
    public string Remark2 { get; set; }
  }
}
