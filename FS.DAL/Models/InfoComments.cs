using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class InfoComments
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public int CommentAdminID { get; set; }

    [ColumnDescription("")]
    public int CommentedAdminID { get; set; }

    [ColumnDescription("")]
    public int InfoID { get; set; }

    [ColumnDescription("")]
    public string Comment { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }
  }
}
