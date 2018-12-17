using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class tempProduct_PushHistory
  {

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int SiteProductID { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }
  }
}
