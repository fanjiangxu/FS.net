using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OptionVal
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("tb_option 外键")]
    public int OptionID { get; set; }

    [ColumnDescription("必选区值")]
    public string OptionVal1 { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("价格")]
    public decimal Price { get; set; }

    [ColumnDescription("状态 0为删除 1为老必选区 2 为新必选区值")]
    public int State { get; set; }

    [ColumnDescription("站点编号")]
    public int SiteID { get; set; }

    [ColumnDescription("单位")]
    public string Unit { get; set; }

    [ColumnDescription("排序")]
    public int Sort { get; set; }

    [ColumnDescription("分组编号")]
    public int GroupID { get; set; }

    [ColumnDescription("法语名称")]
    public string FrOptionVal { get; set; }

    [ColumnDescription("西语名称")]
    public string EsOptionVal { get; set; }

    [ColumnDescription("日语名称")]
    public string JpOptionVal { get; set; }

    [ColumnDescription("俄语名称")]
    public string RuOptionVal { get; set; }
  }
}
