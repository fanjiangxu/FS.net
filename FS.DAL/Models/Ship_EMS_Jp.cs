using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Ship_EMS_Jp
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int CountryID { get; set; }

    [ColumnDescription("")]
    public string CountryName { get; set; }

    [ColumnDescription("")]
    public decimal EMSPrice { get; set; }

    [ColumnDescription("")]
    public decimal EMSAdditional { get; set; }

    [ColumnDescription("")]
    public int EMSType { get; set; }

    [ColumnDescription("")]
    public int EMSZone { get; set; }
  }
}
