using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class RootKeys
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string KeyName { get; set; }

    [ColumnDescription("")]
    public int Count { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }
  }
}
