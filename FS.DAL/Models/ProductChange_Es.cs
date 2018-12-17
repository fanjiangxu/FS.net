using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductChange_Es
  {

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int siteID { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }
  }
}
