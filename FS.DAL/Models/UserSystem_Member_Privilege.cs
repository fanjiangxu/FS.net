using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UserSystem_Member_Privilege
  {

    [ColumnDescription("")]
    public int LevelID { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public decimal CutPrice { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }
  }
}
