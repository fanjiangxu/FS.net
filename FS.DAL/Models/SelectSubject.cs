using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SelectSubject
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserId { get; set; }

    [ColumnDescription("")]
    public string SubjectID { get; set; }
  }
}
