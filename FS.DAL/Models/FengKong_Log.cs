using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class FengKong_Log
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int OrderBillID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int CreateUserID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("默认0:未处理；1:已处理")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int HandleUserID { get; set; }

    [ColumnDescription("")]
    public DateTime HandleDate { get; set; }

    [ColumnDescription("来源。1:服务，2：CMS操作")]
    public int TypeID { get; set; }

    [ColumnDescription("")]
    public int RemoveRemark { get; set; }
  }
}
