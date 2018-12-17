using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class StockpileInfo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("囤货站点ID")]
    public int StockSiteID { get; set; }

    [ColumnDescription("囤货产品编号")]
    public int StockProductID { get; set; }

    [ColumnDescription("出单站点ID")]
    public int OrderSiteID { get; set; }

    [ColumnDescription("出单产品编号")]
    public int OrderProductID { get; set; }

    [ColumnDescription("Pms类别ID")]
    public int PmsCategoryID { get; set; }

    [ColumnDescription("规格")]
    public string Specs { get; set; }

    [ColumnDescription("货号")]
    public string AtrNo { get; set; }

    [ColumnDescription("添加人")]
    public string AddUserName { get; set; }

    [ColumnDescription("添加时间")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("处理时间")]
    public DateTime HandleTime { get; set; }

    [ColumnDescription("处理人员ID")]
    public string HandleUserName { get; set; }

    [ColumnDescription("处理类型")]
    public int HandleType { get; set; }

    [ColumnDescription("状态 0:未处理（默认），1:已处理")]
    public int STATE { get; set; }
  }
}
