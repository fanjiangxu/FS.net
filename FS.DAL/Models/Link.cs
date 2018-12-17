using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Link
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string WebSite { get; set; }

    [ColumnDescription("")]
    public int PR { get; set; }

    [ColumnDescription("")]
    public int GoogleInclude { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public string Country { get; set; }

    [ColumnDescription("")]
    public string KeyWord { get; set; }

    [ColumnDescription("")]
    public string Url { get; set; }

    [ColumnDescription("")]
    public string Type { get; set; }

    [ColumnDescription("")]
    public int GroupID { get; set; }

    [ColumnDescription("")]
    public string Backup { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string Price { get; set; }

    [ColumnDescription("")]
    public int Currency { get; set; }

    [ColumnDescription("")]
    public int Moved { get; set; }

    [ColumnDescription("")]
    public string WhoisMail { get; set; }
  }
}
