using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class CMSRequirement
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public int ForwardId { get; set; }

    [ColumnDescription("")]
    public int implementId { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public DateTime AaccomplishTime { get; set; }

    [ColumnDescription("")]
    public string Explain { get; set; }

    [ColumnDescription("")]
    public int state { get; set; }
  }
}
