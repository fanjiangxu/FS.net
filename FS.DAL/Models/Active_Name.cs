using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Active_Name
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("活动名称")]
    public string Name { get; set; }

    [ColumnDescription("活动类型描述")]
    public string Description { get; set; }

    [ColumnDescription("状态")]
    public int Status { get; set; }

    [ColumnDescription("父级ID")]
    public int ParentID { get; set; }

    [ColumnDescription("创建时间")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("创建用户名")]
    public string CreateUserName { get; set; }

    [ColumnDescription("修改时间")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("修改用户名")]
    public string UpdateUserName { get; set; }

    [ColumnDescription("站点ID")]
    public int SiteID { get; set; }
  }
}
