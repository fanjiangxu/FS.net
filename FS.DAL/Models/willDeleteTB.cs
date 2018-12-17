using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class willDeleteTB
  {

    [ColumnDescription("")]
    public string 序号 { get; set; }

    [ColumnDescription("")]
    public string 包裹号 { get; set; }

    [ColumnDescription("")]
    public string 订单号 { get; set; }

    [ColumnDescription("")]
    public string 站点 { get; set; }

    [ColumnDescription("")]
    public string 仓库 { get; set; }

    [ColumnDescription("")]
    public DateTime 处理日期 { get; set; }

    [ColumnDescription("")]
    public string 处理情况 { get; set; }

    [ColumnDescription("")]
    public string F8 { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
