using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PartTime_Users
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public string UserName { get; set; }

    [ColumnDescription("")]
    public string Phone { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("初始密码")]
    public string IninPassword { get; set; }

    [ColumnDescription("")]
    public int PercentValue { get; set; }

    [ColumnDescription("合作状态:1,合作 2,不合作")]
    public int State { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int AddUser { get; set; }
  }
}
