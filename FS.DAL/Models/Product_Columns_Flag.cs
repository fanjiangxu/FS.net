using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Product_Columns_Flag
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("Type:1,品类 2,产品QA 3,产品重量 4,梯队级别 5,视频链接,6 () ,7 客户是否买大一款衣服")]
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
