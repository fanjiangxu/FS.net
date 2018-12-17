using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OptionContent
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("是否自定制")]
    public int IsCustom { get; set; }

    [ColumnDescription("描述")]
    public string CustomDesc { get; set; }

    [ColumnDescription("自定制价格")]
    public decimal CustomPrice { get; set; }

    [ColumnDescription("TB_Option2 外键")]
    public int OptionID { get; set; }

    [ColumnDescription("1 为分类 2 为产品")]
    public int Type { get; set; }

    [ColumnDescription("关联的产品id 或者分类id")]
    public int CurrentID { get; set; }

    [ColumnDescription("站点编号")]
    public int SiteID { get; set; }

    [ColumnDescription("排序")]
    public int sort { get; set; }

    [ColumnDescription("")]
    public int KID { get; set; }

    [ColumnDescription("状态 -2 为已删除，-1 为已删除等待同步，0 修改，1 正常，2 新增")]
    public int state { get; set; }
  }
}
