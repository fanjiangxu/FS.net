using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Match
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public int Num { get; set; }

    [ColumnDescription("")]
    public decimal Rate { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public int MatchID { get; set; }

    [ColumnDescription("")]
    public string IntroduceUrl { get; set; }

    [ColumnDescription("")]
    public string TopUrl { get; set; }

    [ColumnDescription("")]
    public DateTime StartDate { get; set; }

    [ColumnDescription("")]
    public DateTime EndDate { get; set; }

    [ColumnDescription("")]
    public int BaseMoney { get; set; }
  }
}
