using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class tb_tempProductUpdateStateTime
  {

    [ColumnDescription("")]
    public int productID { get; set; }

    [ColumnDescription("")]
    public string SiteID { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public DateTime beginDate { get; set; }
  }
}
