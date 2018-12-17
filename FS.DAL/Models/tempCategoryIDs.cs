using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class tempCategoryIDs
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public string CategoryIDs { get; set; }

    [ColumnDescription("")]
    public string ParentIDs { get; set; }
  }
}
