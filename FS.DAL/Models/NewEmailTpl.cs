using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class NewEmailTpl
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string header { get; set; }

    [ColumnDescription("")]
    public string footer { get; set; }

    [ColumnDescription("")]
    public int siteID { get; set; }

    [ColumnDescription("")]
    public int LanguageID { get; set; }
  }
}
