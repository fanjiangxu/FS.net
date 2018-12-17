using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Mobile
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Mobile1 { get; set; }

    [ColumnDescription("")]
    public int IsValid { get; set; }
  }
}
