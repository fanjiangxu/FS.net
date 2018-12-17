using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductSubtitleLanguge
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int LanguageID { get; set; }

    [ColumnDescription("")]
    public string Subtitle { get; set; }

    [ColumnDescription("")]
    public string SubtitleUrl { get; set; }

    [ColumnDescription("")]
    public int UpdateOperator { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public int ProductSubtitleID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("1 第一次添加的作为主语言 不可删除")]
    public int FristLang { get; set; }
  }
}
