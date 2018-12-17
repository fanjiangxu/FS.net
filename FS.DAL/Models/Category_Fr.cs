using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Category_Fr
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ParentID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string CNName { get; set; }

    [ColumnDescription("")]
    public int ProductCount { get; set; }

    [ColumnDescription("")]
    public string ParentIDs { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public string Logo { get; set; }

    [ColumnDescription("")]
    public int ShowType { get; set; }

    [ColumnDescription("")]
    public int FakeLevel { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string TitleTags { get; set; }

    [ColumnDescription("")]
    public string KeywordsTags { get; set; }

    [ColumnDescription("")]
    public string DescriptionTags { get; set; }

    [ColumnDescription("")]
    public string Description { get; set; }

    [ColumnDescription("")]
    public decimal CustomPrice { get; set; }

    [ColumnDescription("")]
    public int ProductCount1 { get; set; }

    [ColumnDescription("")]
    public int CategoryNameID { get; set; }

    [ColumnDescription("")]
    public bool IsShow { get; set; }

    [ColumnDescription("")]
    public string Domain { get; set; }

    [ColumnDescription("")]
    public string RedirectUrl { get; set; }

    [ColumnDescription("")]
    public int ImageWidth { get; set; }

    [ColumnDescription("")]
    public int ImageHeight { get; set; }

    [ColumnDescription("")]
    public int IsUserCustomImage { get; set; }

    [ColumnDescription("")]
    public int ImageQuality { get; set; }
  }
}
