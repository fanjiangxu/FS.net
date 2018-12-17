using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ShipMethodDay
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("运输方式；DHL[2：加急]、TNT[4：标准]、Small[7：小包]")]
    public int ShipMethod { get; set; }

    [ColumnDescription("运输方式名称；DHL[加急]、TNT[标准]、Small[小包]")]
    public string ShipMethodName { get; set; }

    [ColumnDescription("国家ID  如果国家ID是0则是默认值")]
    public int CountryID { get; set; }

    [ColumnDescription("最小天数")]
    public int MinDay { get; set; }

    [ColumnDescription("")]
    public int MaxDay { get; set; }
  }
}
