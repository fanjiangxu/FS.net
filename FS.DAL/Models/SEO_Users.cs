using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SEO_Users
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string Password { get; set; }

    [ColumnDescription("")]
    public string PerID { get; set; }

    [ColumnDescription("")]
    public string SitePer { get; set; }

    [ColumnDescription("")]
    public string PermissionID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
