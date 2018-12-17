using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Order_Columns_Flag
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("Type:1 联盟平台")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public int ValueInt { get; set; }

    [ColumnDescription("")]
    public string ValueStr { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int AddUser { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int LastUpdateUser { get; set; }

    [ColumnDescription("")]
    public DateTime LastUpdateTime { get; set; }

    [ColumnDescription("")]
    public string DataLog { get; set; }
  }
}
