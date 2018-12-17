using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Off_Msfairy
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string CategoryIds { get; set; }

    [ColumnDescription("")]
    public string ProductIds { get; set; }

    [ColumnDescription("")]
    public DateTime BeginTime { get; set; }

    [ColumnDescription("")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("")]
    public int Discount { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
