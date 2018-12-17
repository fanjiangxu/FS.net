using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class RootInfoSeo
  {

    [ColumnDescription("")]
    public int RootID { get; set; }

    [ColumnDescription("")]
    public string RootName { get; set; }

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
