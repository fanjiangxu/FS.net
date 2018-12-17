using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SelectiveOrderremarkComment
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int AddUser { get; set; }

    [ColumnDescription("")]
    public int SelectiveOrderremarkID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string Comment { get; set; }

    [ColumnDescription("")]
    public int Xing { get; set; }
  }
}
