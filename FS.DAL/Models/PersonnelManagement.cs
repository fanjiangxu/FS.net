using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PersonnelManagement
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int AdminID { get; set; }

    [ColumnDescription("")]
    public int Group2ID { get; set; }

    [ColumnDescription("")]
    public int PositionID { get; set; }
  }
}
