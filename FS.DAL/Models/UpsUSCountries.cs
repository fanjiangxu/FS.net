using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UpsUSCountries
  {

    [ColumnDescription("")]
    public string zip { get; set; }

    [ColumnDescription("")]
    public string city { get; set; }

    [ColumnDescription("")]
    public string state { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }
  }
}
