using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SetMealPrice_Fr
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int PID { get; set; }

    [ColumnDescription("")]
    public decimal Price1 { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
