using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class EmailSendRule
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int EmailType { get; set; }

    [ColumnDescription("")]
    public string Rule { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string HotStateIDs { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }
  }
}
