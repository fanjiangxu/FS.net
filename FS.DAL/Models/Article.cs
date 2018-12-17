using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Article
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string ArticleTitle { get; set; }

    [ColumnDescription("")]
    public string ArticleContent { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int ArticleCategory { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int IsTop { get; set; }

    [ColumnDescription("")]
    public int adminid { get; set; }

    [ColumnDescription("")]
    public string tags { get; set; }

    [ColumnDescription("")]
    public string Categorys { get; set; }

    [ColumnDescription("")]
    public string Pids { get; set; }

    [ColumnDescription("")]
    public bool UpdateState { get; set; }

    [ColumnDescription("")]
    public int WebCid { get; set; }
  }
}
