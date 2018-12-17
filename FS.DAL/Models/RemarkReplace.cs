using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class RemarkReplace
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public string EnName { get; set; }

    [ColumnDescription("")]
    public string FrName { get; set; }

    [ColumnDescription("")]
    public string EsName { get; set; }

    [ColumnDescription("")]
    public string JpName { get; set; }
  }
}
