using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Option2
  {

    [ColumnDescription("主键")]
    public int ID { get; set; }

    [ColumnDescription("必选区名称")]
    public string Name { get; set; }

    [ColumnDescription("状态")]
    public int State { get; set; }

    [ColumnDescription("法语名称")]
    public string FrName { get; set; }

    [ColumnDescription("西语名称")]
    public string EsName { get; set; }

    [ColumnDescription("日语名称")]
    public string JpName { get; set; }

    [ColumnDescription("俄语名称")]
    public string RuName { get; set; }
  }
}
