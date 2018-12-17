using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class TagInfoSeo
  {

    [ColumnDescription("")]
    public int TagID { get; set; }

    [ColumnDescription("")]
    public string TagName { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string IsCogradient { get; set; }

    [ColumnDescription("")]
    public int TypeID { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int Language { get; set; }

    [ColumnDescription("")]
    public int GetSouse { get; set; }
  }
}
