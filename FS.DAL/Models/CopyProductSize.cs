using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class CopyProductSize
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int DoUserID { get; set; }

    [ColumnDescription("")]
    public DateTime Date { get; set; }

    [ColumnDescription("")]
    public string OldRemark { get; set; }

    [ColumnDescription("")]
    public string NewRemark { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
