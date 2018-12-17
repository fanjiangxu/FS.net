using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Account_UserRoleAssign
  {

    [ColumnDescription("用户ID")]
    public int ID { get; set; }

    [ColumnDescription("角色ID(外键)")]
    public int RoleID { get; set; }

    [ColumnDescription("用户ID(外键)")]
    public int UserID { get; set; }

    [ColumnDescription("过期时间")]
    public DateTime ExpiredTime { get; set; }

    [ColumnDescription("是否可用")]
    public bool IsEnable { get; set; }

    [ColumnDescription("备注")]
    public string Remark { get; set; }

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
