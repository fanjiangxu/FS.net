using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class RegisterLog
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int RegisterType { get; set; }

    [ColumnDescription("")]
    public DateTime RegisterDate { get; set; }

    [ColumnDescription("")]
    public string BeforeUrl { get; set; }
  }
}
