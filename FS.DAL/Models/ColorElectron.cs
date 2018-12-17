using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ColorElectron
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int MaterialID { get; set; }

    [ColumnDescription("")]
    public int ColorPanelID { get; set; }

    [ColumnDescription("")]
    public string ColorID { get; set; }

    [ColumnDescription("")]
    public string ColorPath { get; set; }

    [ColumnDescription("")]
    public string Memo { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int siteid { get; set; }
  }
}
