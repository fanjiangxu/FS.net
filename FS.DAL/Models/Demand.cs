using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Demand
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string Content { get; set; }

    [ColumnDescription("")]
    public string ToDept { get; set; }

    [ColumnDescription("")]
    public int DoUserID { get; set; }

    [ColumnDescription("")]
    public int IsShowName { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
