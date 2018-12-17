using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Php_SiteInfo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string Url { get; set; }

    [ColumnDescription("")]
    public string UserName { get; set; }

    [ColumnDescription("")]
    public string Password { get; set; }

    [ColumnDescription("")]
    public string ApiUrlNew { get; set; }

    [ColumnDescription("")]
    public string ApiUserNameNew { get; set; }

    [ColumnDescription("")]
    public string ApiPasswordNew { get; set; }

    [ColumnDescription("")]
    public int IsNew { get; set; }
  }
}
