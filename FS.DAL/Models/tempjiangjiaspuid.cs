using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class tempjiangjiaspuid
  {

    [ColumnDescription("")]
    public decimal Original { get; set; }

    [ColumnDescription("")]
    public decimal xiugai { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int PID { get; set; }

    [ColumnDescription("")]
    public decimal jiangjilv { get; set; }

    [ColumnDescription("")]
    public decimal jiangjia { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }
  }
}
