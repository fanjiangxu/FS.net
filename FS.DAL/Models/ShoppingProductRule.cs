using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ShoppingProductRule
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string Language { get; set; }

    [ColumnDescription("")]
    public DateTime StartTime { get; set; }

    [ColumnDescription("")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int AddUserID { get; set; }

    [ColumnDescription("")]
    public int RestrictClass { get; set; }

    [ColumnDescription("")]
    public string RestrictID { get; set; }

    [ColumnDescription("")]
    public int HandleUserID { get; set; }

    [ColumnDescription("")]
    public DateTime HandleTime { get; set; }

    [ColumnDescription("")]
    public string PingTai { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public decimal RestrictMonery { get; set; }
  }
}
