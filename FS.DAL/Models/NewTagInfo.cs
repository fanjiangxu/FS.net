using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class NewTagInfo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("名称")]
    public string Name { get; set; }

    [ColumnDescription("排序")]
    public int Sort { get; set; }

    [ColumnDescription("是否启用")]
    public int IsEnable { get; set; }

    [ColumnDescription("是否在导航显示")]
    public int IsShowNav { get; set; }

    [ColumnDescription("是否在列表页左侧显示")]
    public int IsShowLeft { get; set; }

    [ColumnDescription("是否在cms 产品编辑页显示")]
    public int IsShowCms { get; set; }

    [ColumnDescription("添加人")]
    public int AddUser { get; set; }

    [ColumnDescription("添加时间")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("1为 key 2为values")]
    public int TagType { get; set; }

    [ColumnDescription("url 标识")]
    public string NosignName { get; set; }

    [ColumnDescription("分组id")]
    public int GroupId { get; set; }

    [ColumnDescription("站点标识")]
    public int siteid { get; set; }

    [ColumnDescription("")]
    public int OldID { get; set; }
  }
}
