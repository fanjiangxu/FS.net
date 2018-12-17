using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class syscommand
  {

    [ColumnDescription("")]
    public string op { get; set; }

    [ColumnDescription("")]
    public string Id { get; set; }
  }
}
