using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ShipChargesMapping
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("运输方式ID")]
    public int ShipMethod { get; set; }

    [ColumnDescription("运输方式名称；DHL[加急]、TNT[标准]、Small[小包]")]
    public string ShipMethodName { get; set; }

    [ColumnDescription("快递方式ID")]
    public int ShipID { get; set; }

    [ColumnDescription("服务费  美元")]
    public decimal ServiceCharge { get; set; }

    [ColumnDescription("服务费类型；0:固定金额  1:百分比")]
    public int ServiceChargeType { get; set; }

    [ColumnDescription("状态；1可用；0不可用；")]
    public int State { get; set; }
  }
}
