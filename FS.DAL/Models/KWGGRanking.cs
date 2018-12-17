using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class KWGGRanking
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int GGRanking { get; set; }

    [ColumnDescription("")]
    public DateTime CreateDate { get; set; }

    [ColumnDescription("")]
    public int KWID { get; set; }
  }
}
