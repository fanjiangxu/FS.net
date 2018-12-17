using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProjectDetail
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProjectID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public string JoinUser { get; set; }

    [ColumnDescription("")]
    public DateTime DateStart { get; set; }

    [ColumnDescription("")]
    public DateTime DateEnd { get; set; }

    [ColumnDescription("")]
    public DateTime DateFinish { get; set; }

    [ColumnDescription("")]
    public int Progress { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
