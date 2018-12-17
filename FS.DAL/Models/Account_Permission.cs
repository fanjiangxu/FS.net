using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Account_Permission
  {

    [ColumnDescription("自增ID")]
    public int ID { get; set; }

    [ColumnDescription("父ID")]
    public int ParentID { get; set; }

    [ColumnDescription("权限KEY")]
    public string PermissionKey { get; set; }

    [ColumnDescription("权限名称")]
    public string Name { get; set; }

    [ColumnDescription("描述")]
    public string Description { get; set; }

    [ColumnDescription("图标")]
    public string Icon { get; set; }

    [ColumnDescription("是否成为导航菜单")]
    public bool CanMenu { get; set; }

    [ColumnDescription("其他数据[Json]")]
    public string Data { get; set; }

    [ColumnDescription("导航连接")]
    public string Href { get; set; }

    [ColumnDescription("是否可用")]
    public bool IsEnable { get; set; }

    [ColumnDescription("排序")]
    public int Sort { get; set; }

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
