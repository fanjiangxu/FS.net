using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class LinkPriceContinue
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int GroupID { get; set; }

    [ColumnDescription("")]
    public int Price { get; set; }

    [ColumnDescription("")]
    public DateTime StartDate { get; set; }

    [ColumnDescription("")]
    public DateTime EndDate { get; set; }
  }
}
