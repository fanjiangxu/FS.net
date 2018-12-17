using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Ship_Reduction_Rule
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ReductionID { get; set; }

    [ColumnDescription("")]
    public decimal StartWeight { get; set; }

    [ColumnDescription("")]
    public decimal EndWeight { get; set; }

    [ColumnDescription("减免重量单位 如果是0则是 总重量减去StartWeight 除以 此值 再乘以 Money得到总减去金额 公式：(（总重量-StartWeight）/ ReductionWeightUnit)*Money   不是0则直接减免Money值")]
    public decimal ReductionWeightUnit { get; set; }

    [ColumnDescription("按单位减免之前的基础减免金额")]
    public decimal ReductionBaseMoney { get; set; }

    [ColumnDescription("")]
    public decimal Money { get; set; }
  }
}
