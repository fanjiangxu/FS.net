using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SEO_Tag
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string TagName { get; set; }

    [ColumnDescription("")]
    public int TagType { get; set; }

    [ColumnDescription("")]
    public int TagCategory { get; set; }

    [ColumnDescription("")]
    public string TagCategories { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int Lan { get; set; }

    [ColumnDescription("")]
    public string CategoryIds { get; set; }

    [ColumnDescription("")]
    public int SearchNumber { get; set; }

    [ColumnDescription("")]
    public string competitive { get; set; }

    [ColumnDescription("")]
    public int TagLine { get; set; }

    [ColumnDescription("")]
    public int TagSource { get; set; }

    [ColumnDescription("")]
    public int TagLevel { get; set; }

    [ColumnDescription("")]
    public int TagGroup { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public string Description { get; set; }

    [ColumnDescription("")]
    public string Code { get; set; }

    [ColumnDescription("")]
    public string Url { get; set; }
  }
}
