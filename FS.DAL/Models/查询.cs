using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class 查询
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string 站点 { get; set; }

    [ColumnDescription("")]
    public string 邮箱 { get; set; }

    [ColumnDescription("")]
    public DateTime 注册时间 { get; set; }

    [ColumnDescription("")]
    public DateTime 最后一次登录 { get; set; }

    [ColumnDescription("")]
    public DateTime 最后一次支付 { get; set; }

    [ColumnDescription("")]
    public DateTime 最后一次下单 { get; set; }
  }
}
