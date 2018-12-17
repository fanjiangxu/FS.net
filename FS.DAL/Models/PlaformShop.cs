using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PlaformShop
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int PlatFormID { get; set; }

    [ColumnDescription("")]
    public string ShopName { get; set; }

    [ColumnDescription("")]
    public string CompanyName { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string OriginalShopID { get; set; }
  }
}
