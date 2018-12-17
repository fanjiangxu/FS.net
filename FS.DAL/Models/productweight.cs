using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class productweight
  {

    [ColumnDescription("")]
    public string tidebuyid { get; set; }

    [ColumnDescription("")]
    public string dressfirmid { get; set; }

    [ColumnDescription("")]
    public string ericdressid { get; set; }

    [ColumnDescription("")]
    public string weight { get; set; }

    [ColumnDescription("")]
    public string weight2 { get; set; }

    [ColumnDescription("")]
    public string money { get; set; }
  }
}
