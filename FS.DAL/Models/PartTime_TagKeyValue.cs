using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PartTime_TagKeyValue
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int siteid { get; set; }

    [ColumnDescription("")]
    public int KeyID { get; set; }

    [ColumnDescription("")]
    public int ValID { get; set; }

    [ColumnDescription("")]
    public int CurrentID { get; set; }

    [ColumnDescription("")]
    public int Status { get; set; }

    [ColumnDescription("")]
    public int MappType { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }
  }
}
