using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class InfoModel
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int parentID { get; set; }

    [ColumnDescription("分类ID")]
    public int CategoryID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public string Content { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public DateTime DelDate { get; set; }

    [ColumnDescription("")]
    public int DelUserID { get; set; }

    [ColumnDescription("")]
    public int CreateUserID { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }
  }
}
