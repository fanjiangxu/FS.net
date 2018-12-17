using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductOriginalLink
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public string Link { get; set; }

    [ColumnDescription("")]
    public int ProductState { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
