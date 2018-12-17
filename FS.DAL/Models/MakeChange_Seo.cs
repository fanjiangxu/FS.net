using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MakeChange_Seo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public int ParentID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("1:WWW，   2:M，   3:APP")]
    public int SiteType { get; set; }

    [ColumnDescription("")]
    public string StartUrl { get; set; }

    [ColumnDescription("多个时，以“#”号连接")]
    public string Regex { get; set; }

    [ColumnDescription("检测是否有数据   1:链接（默认），   2:文本，   3:图片")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("1:启用（默认）   0:禁用")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int IsNext { get; set; }

    [ColumnDescription("随机抽查个数，默认为0时全部查询")]
    public int RandomCount { get; set; }
  }
}
