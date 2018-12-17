using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Plaform_Wish_Country_Mapping
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string CNName { get; set; }

    [ColumnDescription("")]
    public int CountryID { get; set; }

    [ColumnDescription("")]
    public int EUB { get; set; }

    [ColumnDescription("")]
    public int CPAM { get; set; }

    [ColumnDescription("")]
    public int Bpost { get; set; }

    [ColumnDescription("")]
    public int wishChinaPost { get; set; }

    [ColumnDescription("")]
    public int Else { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }
  }
}
