using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class temp_ProductWeight_site
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public decimal ProductWeight { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
