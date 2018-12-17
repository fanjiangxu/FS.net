using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class NewTagInfoKeyValueMapping
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("key id ")]
    public int KeyID { get; set; }

    [ColumnDescription("values  id ")]
    public int ValID { get; set; }

    [ColumnDescription("产品id 或者分类id")]
    public int CurrentID { get; set; }

    [ColumnDescription("状态")]
    public int Status { get; set; }

    [ColumnDescription("2 为产品 1为分类")]
    public int MappType { get; set; }

    [ColumnDescription("排序")]
    public int Sort { get; set; }

    [ColumnDescription("站点标识")]
    public int siteid { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }
  }
}
