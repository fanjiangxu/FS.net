using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class CurrentShares
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string Code { get; set; }

    [ColumnDescription("")]
    public int CurrentShare { get; set; }

    [ColumnDescription("")]
    public int CanUseShare { get; set; }

    [ColumnDescription("")]
    public decimal CurrentPrice { get; set; }

    [ColumnDescription("")]
    public decimal Increase { get; set; }

    [ColumnDescription("")]
    public decimal BasePrice { get; set; }

    [ColumnDescription("")]
    public decimal TotalMoney { get; set; }

    [ColumnDescription("")]
    public decimal FloatingPL { get; set; }

    [ColumnDescription("")]
    public decimal PLScale { get; set; }

    [ColumnDescription("")]
    public decimal ChiCangZB { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string UserName { get; set; }
  }
}
