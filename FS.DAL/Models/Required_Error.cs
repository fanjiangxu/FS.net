using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Required_Error
  {

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string PmsCategoryName { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateDate { get; set; }
  }
}
