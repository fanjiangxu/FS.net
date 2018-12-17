using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Ship
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("快递方式名称")]
    public string Name { get; set; }

    [ColumnDescription("状态;1,有效  0,无效")]
    public int State { get; set; }
  }
}
