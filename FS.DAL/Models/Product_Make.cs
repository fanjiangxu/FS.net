using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Product_Make
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int MakeType { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public DateTime MakeTime { get; set; }

    [ColumnDescription("")]
    public int CreateUserID { get; set; }

    [ColumnDescription("")]
    public string CreateUserName { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public int MakeState { get; set; }

    [ColumnDescription("")]
    public string MakeRemark { get; set; }

    [ColumnDescription("")]
    public int LastUpdateAdminID { get; set; }

    [ColumnDescription("")]
    public string LastUpdateAdminName { get; set; }

    [ColumnDescription("")]
    public DateTime LastUpdateDate { get; set; }

    [ColumnDescription("")]
    public int ProState { get; set; }

    [ColumnDescription("")]
    public string ProRemark { get; set; }
  }
}
