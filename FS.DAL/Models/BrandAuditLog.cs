using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class BrandAuditLog
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int Status { get; set; }

    [ColumnDescription("")]
    public string LogName { get; set; }

    [ColumnDescription("")]
    public string LogValue { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
