using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Account_UserPermissionAssign
  {

    [ColumnDescription("自增ID")]
    public int ID { get; set; }

    [ColumnDescription("用户ID")]
    public int UserID { get; set; }

    [ColumnDescription("权限ID")]
    public int PermissionID { get; set; }

    [ColumnDescription("分配类型[枚举]:排除，包含")]
    public int AssignType { get; set; }

    [ColumnDescription("是否可用")]
    public bool IsEnable { get; set; }

    [ColumnDescription("过期时间")]
    public DateTime ExpiredTime { get; set; }

    [ColumnDescription("")]
    public string CreateUserName { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string UpdateUserName { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }
  }
}
