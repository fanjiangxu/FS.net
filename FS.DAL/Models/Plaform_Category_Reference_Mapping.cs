using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Plaform_Category_Reference_Mapping
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int AliCategoryID { get; set; }

    [ColumnDescription("")]
    public string AliFirstName { get; set; }

    [ColumnDescription("")]
    public string AliSecondName { get; set; }

    [ColumnDescription("")]
    public string AliThirdName { get; set; }

    [ColumnDescription("")]
    public string AliForthName { get; set; }

    [ColumnDescription("")]
    public string PmsPinLeiName { get; set; }

    [ColumnDescription("")]
    public int PmsPinLeiID { get; set; }

    [ColumnDescription("")]
    public string IsBrand { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int DeliveryTime { get; set; }

    [ColumnDescription("")]
    public int ExtraPackingWeight { get; set; }

    [ColumnDescription("")]
    public string GroupName { get; set; }
  }
}
