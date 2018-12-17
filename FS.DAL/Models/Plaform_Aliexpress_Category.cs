using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Plaform_Aliexpress_Category
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string CnName { get; set; }

    [ColumnDescription("")]
    public string IsLeaf { get; set; }

    [ColumnDescription("")]
    public int Level { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int ParentID { get; set; }

    [ColumnDescription("")]
    public int IsBrand { get; set; }

    [ColumnDescription("")]
    public int DeliveryTime { get; set; }

    [ColumnDescription("")]
    public int ExtraPackingWeight { get; set; }

    [ColumnDescription("")]
    public int ValidNum { get; set; }
  }
}
