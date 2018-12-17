using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Account_GroupPermissionAssign
  {

    [ColumnDescription("自增ID")]
    public int ID { get; set; }

    [ColumnDescription("用户组ID(外键)")]
    public int GroupID { get; set; }

    [ColumnDescription("权限ID(外键)")]
    public int PermissionID { get; set; }

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
