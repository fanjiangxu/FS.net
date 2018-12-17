using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Category_Lang_Custom
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int CategoryId { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public int LanguageId { get; set; }

    [ColumnDescription("")]
    public int IntValue { get; set; }

    [ColumnDescription("1:Sort值[暂时不用]    2:是否显示")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public int AddUser { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("只是后台需要")]
    public string DataLog { get; set; }
  }
}
