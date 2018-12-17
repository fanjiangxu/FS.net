using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UsersRemark
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int AddUserID { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
