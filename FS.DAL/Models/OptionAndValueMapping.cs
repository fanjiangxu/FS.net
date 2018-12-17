using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OptionAndValueMapping
  {

    [ColumnDescription("主键标识")]
    public int ID { get; set; }

    [ColumnDescription("TB_OptionContent 外键")]
    public int OptionContentID { get; set; }

    [ColumnDescription("TB_OptionVal 外键")]
    public int OptionValID { get; set; }

    [ColumnDescription("排序")]
    public int Sort { get; set; }

    [ColumnDescription("站点编号")]
    public int SiteID { get; set; }

    [ColumnDescription("是否是默认项")]
    public int isDefault { get; set; }

    [ColumnDescription("价格")]
    public decimal Price { get; set; }

    [ColumnDescription("状态值 -2 已删除 -1 为删除等待同步 0 修改  1 正常 2 新增")]
    public int state { get; set; }

    [ColumnDescription("备货期")]
    public int PrepareDate { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }
  }
}
