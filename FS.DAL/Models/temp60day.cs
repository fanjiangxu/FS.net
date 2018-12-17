using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class temp60day
  {

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public int PmsCategoryID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int SaleCount { get; set; }
  }
}
