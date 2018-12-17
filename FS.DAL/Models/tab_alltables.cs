using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class tab_alltables
  {

    [ColumnDescription("")]
    public string db { get; set; }

    [ColumnDescription("")]
    public string tab { get; set; }

    [ColumnDescription("")]
    public DateTime cdate { get; set; }
  }
}
