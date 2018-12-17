using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ShipCharges
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("快递方式ID")]
    public int ShipID { get; set; }

    [ColumnDescription("")]
    public int CountryID { get; set; }

    [ColumnDescription("")]
    public decimal StartWeight { get; set; }

    [ColumnDescription("")]
    public decimal EndWeight { get; set; }

    [ColumnDescription("计算公式或者是固定价格")]
    public string Formula { get; set; }

    [ColumnDescription("状态  1，有效   0，无效")]
    public int State { get; set; }
  }
}
