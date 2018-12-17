using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UsersFB
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string BindID { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public DateTime ExpireDate { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
