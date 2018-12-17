using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UserSiteGroupLog
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OldAdminID { get; set; }

    [ColumnDescription("")]
    public int NewAdminID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string Context { get; set; }

    [ColumnDescription("")]
    public int UpdateOrderID { get; set; }
  }
}
