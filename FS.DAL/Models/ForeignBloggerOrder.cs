using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ForeignBloggerOrder
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int IsSend { get; set; }

    [ColumnDescription("")]
    public int IsBlogger { get; set; }

    [ColumnDescription("")]
    public int AddUserF { get; set; }

    [ColumnDescription("")]
    public DateTime AddDateF { get; set; }

    [ColumnDescription("")]
    public string RemarkF { get; set; }

    [ColumnDescription("")]
    public decimal OrderMoneyF { get; set; }

    [ColumnDescription("")]
    public int AdminID { get; set; }
  }
}
