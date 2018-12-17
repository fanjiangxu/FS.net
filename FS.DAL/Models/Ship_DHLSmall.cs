using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Ship_DHLSmall
  {

    [ColumnDescription("主键ID")]
    public int ID { get; set; }

    [ColumnDescription("国家ID ")]
    public int CountryID { get; set; }

    [ColumnDescription("国家名称")]
    public string CountryName { get; set; }

    [ColumnDescription("挂号费/单位(人民币)")]
    public decimal RegistrationFee { get; set; }

    [ColumnDescription("每公斤单价/单位(人民币)")]
    public decimal UnitPrice { get; set; }
  }
}
