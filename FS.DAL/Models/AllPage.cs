using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class AllPage
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string PageName { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }
  }
}
