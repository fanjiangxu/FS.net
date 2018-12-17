using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UserSystem_Level
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string CName { get; set; }

    [ColumnDescription("")]
    public decimal ConsumeStart { get; set; }

    [ColumnDescription("")]
    public decimal ConsumeEnd { get; set; }

    [ColumnDescription("")]
    public decimal Discount { get; set; }
  }
}
