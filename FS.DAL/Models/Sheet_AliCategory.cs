using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Sheet_AliCategory
  {

    [ColumnDescription("")]
    public string 一级类目 { get; set; }

    [ColumnDescription("")]
    public string 二级类目 { get; set; }

    [ColumnDescription("")]
    public string 三级类目 { get; set; }

    [ColumnDescription("")]
    public string 四级类目 { get; set; }

    [ColumnDescription("")]
    public string PMSName { get; set; }

    [ColumnDescription("")]
    public string PMSID { get; set; }

    [ColumnDescription("")]
    public string 是否可填无品牌 { get; set; }

    [ColumnDescription("")]
    public string F8 { get; set; }

    [ColumnDescription("")]
    public string F9 { get; set; }
  }
}
