using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UserSiteGroupID
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public int UserId150 { get; set; }

    [ColumnDescription("")]
    public int UserId223 { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int SiteId233 { get; set; }

    [ColumnDescription("")]
    public int Lang { get; set; }

    [ColumnDescription("")]
    public int PriorityNum { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }
  }
}
