using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Sync
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("类型,1 为发货状态")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public string Json { get; set; }

    [ColumnDescription("状态值0 为未处理。1已处理")]
    public int State { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }
  }
}
