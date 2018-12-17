using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Product_DownShelf
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string CreateUser { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string DownUserID { get; set; }

    [ColumnDescription("")]
    public DateTime DownTime { get; set; }

    [ColumnDescription("")]
    public string Specification { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }

    [ColumnDescription("")]
    public string ProncipalUserName { get; set; }

    [ColumnDescription("")]
    public string SkuIDs { get; set; }
  }
}
