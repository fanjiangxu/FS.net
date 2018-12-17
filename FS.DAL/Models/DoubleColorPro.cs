using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class DoubleColorPro
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int Top_MaterailID { get; set; }

    [ColumnDescription("")]
    public string Top_Sehao { get; set; }

    [ColumnDescription("")]
    public int Below_MaterailID { get; set; }

    [ColumnDescription("")]
    public string Below_Sehao { get; set; }

    [ColumnDescription("")]
    public DateTime addDate { get; set; }

    [ColumnDescription("")]
    public int Siteid { get; set; }
  }
}
