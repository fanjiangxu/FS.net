using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Account_User
  {

    [ColumnDescription("用户ID")]
    public int ID { get; set; }

    [ColumnDescription("昵称")]
    public string PetName { get; set; }

    [ColumnDescription("真实姓名")]
    public string RealName { get; set; }

    [ColumnDescription("登录账户")]
    public string LoginAccount { get; set; }

    [ColumnDescription("登录密码")]
    public string LoginPassword { get; set; }

    [ColumnDescription("最后一次登录时间")]
    public DateTime LoginTime { get; set; }

    [ColumnDescription("最后一次登录IP")]
    public string LoginIP { get; set; }

    [ColumnDescription("用户状态[枚举]：正常，冻结，注销.....")]
    public int Status { get; set; }

    [ColumnDescription("手机/座机")]
    public string Phone { get; set; }

    [ColumnDescription("邮箱")]
    public string Email { get; set; }

    [ColumnDescription("所属组文本(冗余字段,用“,”分割)")]
    public string GroupText { get; set; }

    [ColumnDescription("所属角色(冗余字段，用“,”分割)")]
    public string RoleText { get; set; }

    [ColumnDescription("所属部门")]
    public string Department { get; set; }

    [ColumnDescription("[枚举]用户类型;踏浪人员=0,供应商=1")]
    public int UserType { get; set; }

    [ColumnDescription("用户HasH,可用于找回密码以及清空用户缓存使用")]
    public string Hash { get; set; }

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
