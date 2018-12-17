using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class NoIndexTime
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public DateTime BeganTime { get; set; }

    [ColumnDescription("")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public int CreateUserId { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public int UpdateUserId { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
