using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class InspectRecord
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int WebSiteID { get; set; }

    [ColumnDescription("")]
    public int Include { get; set; }

    [ColumnDescription("")]
    public int LinkNum { get; set; }

    [ColumnDescription("")]
    public DateTime CreateDate { get; set; }
  }
}
