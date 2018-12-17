using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Product_MoteInfoKey_CulturePart
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int CultureID { get; set; }

    [ColumnDescription("")]
    public int MoteInfoKeyID { get; set; }

    [ColumnDescription("")]
    public string Text { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public string CreateUserName { get; set; }

    [ColumnDescription("")]
    public string UpdateUserName { get; set; }
  }
}
