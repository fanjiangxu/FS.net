using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Plaform_Prodcut_Attributes
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }

    [ColumnDescription("")]
    public string AliCategoryID { get; set; }

    [ColumnDescription("")]
    public string AttributeInfo { get; set; }

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
