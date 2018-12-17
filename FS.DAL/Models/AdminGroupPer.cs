using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class AdminGroupPer
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string GroupName { get; set; }

    [ColumnDescription("")]
    public string Permission { get; set; }
  }
}
