using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Mote
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string PmsUrl { get; set; }

    [ColumnDescription("")]
    public string CmsUrl { get; set; }
  }
}
