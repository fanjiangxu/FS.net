using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ChangeEmailLog
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string UserEmail { get; set; }

    [ColumnDescription("")]
    public string NewuserEmail { get; set; }

    [ColumnDescription("")]
    public string SID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime Adddate { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
