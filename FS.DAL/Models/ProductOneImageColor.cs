using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductOneImageColor
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public string Color { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int AddAdminID { get; set; }

    [ColumnDescription("")]
    public DateTime DeleteDate { get; set; }

    [ColumnDescription("")]
    public int DeleteAdminID { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public string color_jp { get; set; }

    [ColumnDescription("")]
    public string Color_fr { get; set; }

    [ColumnDescription("")]
    public string Color_es { get; set; }
  }
}
