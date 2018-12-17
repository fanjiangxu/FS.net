using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Account_Role
  {

    [ColumnDescription("自增ID")]
    public int ID { get; set; }

    [ColumnDescription("名称")]
    public string Name { get; set; }

    [ColumnDescription("描述")]
    public string Description { get; set; }

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
