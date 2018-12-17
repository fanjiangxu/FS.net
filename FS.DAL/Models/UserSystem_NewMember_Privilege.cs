using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UserSystem_NewMember_Privilege
  {

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public decimal CutPrice { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }
  }
}
