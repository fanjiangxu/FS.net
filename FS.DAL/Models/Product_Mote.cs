using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Product_Mote
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string Image { get; set; }

    [ColumnDescription("")]
    public DateTime Birthday { get; set; }

    [ColumnDescription("")]
    public string Sex { get; set; }

    [ColumnDescription("")]
    public string Phone { get; set; }

    [ColumnDescription("")]
    public bool IsEnable { get; set; }

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
