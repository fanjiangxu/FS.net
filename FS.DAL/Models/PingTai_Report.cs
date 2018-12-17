using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PingTai_Report
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int PingTai { get; set; }

    [ColumnDescription("")]
    public DateTime DateTime { get; set; }

    [ColumnDescription("")]
    public decimal Money { get; set; }
  }
}
