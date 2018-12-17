using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UserMatchInfo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Type { get; set; }

    [ColumnDescription("")]
    public string Gid { get; set; }

    [ColumnDescription("")]
    public string Uid { get; set; }

    [ColumnDescription("")]
    public string Web_id { get; set; }

    [ColumnDescription("")]
    public string Archive { get; set; }

    [ColumnDescription("")]
    public string All_balance { get; set; }

    [ColumnDescription("")]
    public string Html { get; set; }
  }
}
