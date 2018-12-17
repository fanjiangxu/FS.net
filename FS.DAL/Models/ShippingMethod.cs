using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ShippingMethod
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string FuelSurcharge { get; set; }

    [ColumnDescription("")]
    public string Discount { get; set; }

    [ColumnDescription("")]
    public decimal Rate { get; set; }

    [ColumnDescription("")]
    public string Other { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int IsExpedited { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string Desc { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
