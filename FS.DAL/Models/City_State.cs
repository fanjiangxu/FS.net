using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class City_State
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int CountryID { get; set; }

    [ColumnDescription("")]
    public string State { get; set; }

    [ColumnDescription("")]
    public string ShortName { get; set; }
  }
}
