using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class tempOptionContent
  {

    [ColumnDescription("")]
    public int CurrentID { get; set; }

    [ColumnDescription("")]
    public string OptionVal { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }

    [ColumnDescription("")]
    public int SaleCount { get; set; }

    [ColumnDescription("")]
    public int PmsCategoryID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }
  }
}
