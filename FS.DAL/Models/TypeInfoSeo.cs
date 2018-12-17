using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class TypeInfoSeo
  {

    [ColumnDescription("")]
    public int TypeID { get; set; }

    [ColumnDescription("")]
    public string TypeName { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string ThresholdValue { get; set; }

    [ColumnDescription("")]
    public string IsCogradient { get; set; }

    [ColumnDescription("")]
    public int ParentID { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public DateTime LastCreateTime { get; set; }

    [ColumnDescription("")]
    public int Language { get; set; }

    [ColumnDescription("")]
    public int GetSouse { get; set; }
  }
}
