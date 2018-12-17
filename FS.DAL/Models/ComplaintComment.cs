using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ComplaintComment
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public int AddUser { get; set; }

    [ColumnDescription("")]
    public int InfoId { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string Comment { get; set; }

    [ColumnDescription("")]
    public int Xing { get; set; }
  }
}
