using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class InfoModel_Category
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("分类名称")]
    public string Name { get; set; }

    [ColumnDescription("父级分类ID")]
    public int ParentID { get; set; }

    [ColumnDescription("状态    1：启用   0：删除")]
    public int Status { get; set; }

    [ColumnDescription("删除时间")]
    public DateTime DeleteTime { get; set; }

    [ColumnDescription("删除用户ID【后台管理员ID】")]
    public int DeleteUserID { get; set; }
  }
}
