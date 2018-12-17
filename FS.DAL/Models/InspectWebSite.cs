using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class InspectWebSite
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string WebSite { get; set; }

    [ColumnDescription("")]
    public string Url { get; set; }
  }
}
