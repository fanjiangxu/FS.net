using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class MoveRecord
  {

    [ColumnDescription("")]
    public int InfoID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public DateTime MoveDate { get; set; }

    [ColumnDescription("")]
    public int FromFolderID { get; set; }

    [ColumnDescription("")]
    public int ToFolderID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }
  }
}
