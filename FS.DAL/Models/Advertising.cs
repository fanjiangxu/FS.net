using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Advertising
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int GroupID { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public string ImgUrl { get; set; }

    [ColumnDescription("")]
    public string AltLable { get; set; }

    [ColumnDescription("")]
    public string Url { get; set; }

    [ColumnDescription("")]
    public int Level { get; set; }

    [ColumnDescription("")]
    public int CidOne { get; set; }

    [ColumnDescription("")]
    public int CidTwo { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public bool IfDesc { get; set; }

    [ColumnDescription("")]
    public DateTime PeriodStart { get; set; }

    [ColumnDescription("")]
    public DateTime PeriodEnd { get; set; }

    [ColumnDescription("")]
    public int DataType { get; set; }

    [ColumnDescription("")]
    public string DataRules { get; set; }

    [ColumnDescription("")]
    public string CountDown { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public DateTime UseTime { get; set; }

    [ColumnDescription("")]
    public bool IfDel { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string adverTitle { get; set; }

    [ColumnDescription("")]
    public int ImgHeigh { get; set; }

    [ColumnDescription("")]
    public int ImgWidth { get; set; }
  }
}
