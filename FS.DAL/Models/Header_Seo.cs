using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Header_Seo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int SiteType { get; set; }

    [ColumnDescription("")]
    public string HeaderID { get; set; }

    [ColumnDescription("")]
    public int AddUserID { get; set; }

    [ColumnDescription("")]
    public int EditUserID { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string HeaderEmail { get; set; }
  }
}
