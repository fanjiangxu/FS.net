using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class FengKong_Data
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string CountryName { get; set; }

    [ColumnDescription("")]
    public string City { get; set; }

    [ColumnDescription("")]
    public string Provience { get; set; }

    [ColumnDescription("")]
    public string Address1 { get; set; }

    [ColumnDescription("")]
    public string Address2 { get; set; }

    [ColumnDescription("")]
    public string UserName { get; set; }

    [ColumnDescription("")]
    public string PostCode { get; set; }

    [ColumnDescription("")]
    public string Phone { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int AddUser { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int LastUpdateBy { get; set; }

    [ColumnDescription("")]
    public DateTime LastUpdateTime { get; set; }
  }
}
