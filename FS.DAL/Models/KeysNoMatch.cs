using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class KeysNoMatch
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string ToUrl { get; set; }

    [ColumnDescription("")]
    public decimal SearchNum { get; set; }

    [ColumnDescription("")]
    public bool Auto { get; set; }

    [ColumnDescription("")]
    public int CategoryID { get; set; }
  }
}
