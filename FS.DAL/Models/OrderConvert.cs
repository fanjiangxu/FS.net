using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderConvert
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("转化率")]
    public decimal OrderConvert1 { get; set; }

    [ColumnDescription("开始时间")]
    public int StartTime { get; set; }

    [ColumnDescription("结束时间")]
    public int EndTime { get; set; }

    [ColumnDescription("监控的时间段 单位:分钟")]
    public int Times { get; set; }
  }
}
